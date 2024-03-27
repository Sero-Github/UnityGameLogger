using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace UnityGameLogger
{
	public partial class MainForm : Form
	{

		[DllImport("user32")]
        private static extern int SetWindowText(int hWnd, string lpString);
        [DllImport("user32")]
        private static extern int FindWindowA(string lpClasssName, string lpWindowName);

		private readonly string adbPath = "scrcpy\\adb.exe";
		private readonly string logDirectory = Environment.CurrentDirectory + "\\Android-LOG";

		public MainForm()
		{
			InitializeComponent();

			TrayIcon.Visible = true;
			TrayIcon.ContextMenuStrip = ContextMenu;

			try
			{
				ADBDevice();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		#region winuser.h 
		protected override void WndProc(ref Message m)
		{
			UInt32 WM_DEVICECHANGE = 0x0219;
			//UInt32 DBT_DEVTUP_VOLUME = 0x02;
			UInt32 DBT_DEVICEARRIVAL = 0x8000;
			UInt32 DBT_DEVICEREMOVECOMPLETE = 0x8004;

			Boolean deviceConnect = (m.Msg == WM_DEVICECHANGE) && (m.WParam.ToInt32() == DBT_DEVICEARRIVAL);
			Boolean deviceUnconnect = (m.Msg == WM_DEVICECHANGE) && (m.WParam.ToInt32() == DBT_DEVICEREMOVECOMPLETE);

			if (deviceConnect || deviceUnconnect) {
				Thread.Sleep(1000);
				ADBDevice();
			}

			base.WndProc(ref m);
		}
		#endregion

		#region Buttons
		private void ButtonOpenLogFolder1_Click(object sender, EventArgs e)
		{
			Process.Start("explorer.exe", Program.configLoader.LogConfigs[0].LogDirectory);
		}
		private void ButtonOpenLogFolder2_Click(object sender, EventArgs e)
		{
			Process.Start("explorer.exe", Program.configLoader.LogConfigs[1].LogDirectory);
		}

		private void ButtonSetting_Click(object sender, EventArgs e)
		{
			this.Hide();
			using (SettingForm settingForm = new SettingForm())
				settingForm.ShowDialog();
			this.Show();
		}

		private void ButtonQuitProgram_Click(object sender, EventArgs e)
		{
			ExitProgram();
		}

		private void ButtonHelpPage_Click(object sender, EventArgs e)
		{
			string url = @"";
			Process.Start(url);
		}
		#endregion
		
		#region MainForm
		private void MainForm_Load(object sender, EventArgs e)
		{
			TextBoxProjectName.Text = Program.configLoader.ProjectConfig.ProjectName;
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Hide();
			e.Cancel = true;
		}

		private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.Show();
		}
		#endregion

		private void ExitProgram()
		{
			DialogResult isClose = MessageBox.Show("종료 시 로그 저장이 자동으로 되지 않습니다.\n종료하시겠습니까?", "프로그램 종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (isClose == DialogResult.Yes)
			{
				Environment.Exit(0);
			}
		}

		private void ADBDevice()
		{
			if (File.Exists(adbPath))
			{
				ListBoxDevices.Items.Clear();

				Process proc = new Process
				{
					StartInfo = new ProcessStartInfo
					{
						FileName = adbPath,
						Arguments = "devices",
						UseShellExecute = false,
						RedirectStandardOutput = true,
						CreateNoWindow = true
					}
				};
				proc.Start();

				while (!proc.StandardOutput.EndOfStream)
				{
					string[] line = proc.StandardOutput.ReadLine().Split('\t');

					if (line.Length == 2 && line[1] == "device")
					{
						ListBoxDevices.Items.Add(line[0]);
					}
				}
			}
		}

		private void ButtonADBDevice_Click(object sender, EventArgs e)
		{
			ADBDevice();

			if (ListBoxDevices.Items.Count == 0)
			{
				MessageBox.Show("검색된 기기가 없습니다.\nUSB 디버깅이 허용되었는지 확인해주세요.","오류",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				MessageBox.Show("기기 검색이 완료되었습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void ButtonADBExtract_Click(object sender, EventArgs e)
		{
			string timeStamp = DateTime.Now.ToString("yyyy-MM-dd_HHmmss");
			if (ListBoxDevices.SelectedIndex != -1)
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(logDirectory);
				if (!directoryInfo.Exists)
					directoryInfo.Create();

				string logFileName = $"{ListBoxDevices.SelectedItem}_{timeStamp}.log";
				string logPath = Path.Combine(logDirectory, logFileName);
				string logcatArgument = $@"/c adbPath -s {ListBoxDevices.SelectedItem} logcat -d > {logPath}";

				Process logcatShell = new Process
				{
					StartInfo = new ProcessStartInfo
					{
						FileName = "cmd",
						Arguments = logcatArgument,
						UseShellExecute = false,
						RedirectStandardOutput = true,
						CreateNoWindow = true
					}
				};
				logcatShell.Start();

				string logUnityFileName = $"{ListBoxDevices.SelectedItem}_{timeStamp}-UnityLog";
				string logUnityPath = Path.Combine(logDirectory, logUnityFileName);
				string logcatUnityArgument = $@"/c {adbPath} -s {ListBoxDevices.SelectedItem} logcat -d -s Unity > {logUnityPath}";

				Process logcatUnityShell = new Process
				{
					StartInfo = new ProcessStartInfo
					{
						FileName = "cmd",
						Arguments = logcatUnityArgument,
						UseShellExecute = false,
						RedirectStandardOutput = true,
						CreateNoWindow = true
					}
				};
				logcatUnityShell.Start();

				StringBuilder msgText = new StringBuilder();
				msgText.Append(ListBoxDevices.SelectedItem.ToString()  + " 기기의 로그 추출이 완료되었습니다.\n");
				msgText.Append("LOG : " + logFileName + ".log\n");
				msgText.Append("Unity Log : " + logFileName + "-Unity.log");

				MessageBox.Show(msgText.ToString(), "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("기기를 선택해주세요.","오류",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		private void ButtonADBLogClear_Click(object sender, EventArgs e)
		{
			if (ListBoxDevices.SelectedIndex != -1)
			{
				DialogResult dialogResult = MessageBox.Show(ListBoxDevices.SelectedItem.ToString() + " 기기의 로그를 초기화할까요?",
					"확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

				if (dialogResult == DialogResult.Yes)
				{
					StringBuilder logcatArgument = new StringBuilder();
					logcatArgument.Append("/c ");
					logcatArgument.Append(adbPath + " ");
					logcatArgument.Append("-s " + ListBoxDevices.SelectedItem.ToString() + " ");
					logcatArgument.Append("logcat ");
					logcatArgument.Append("-c ");

					Process logcatShell = new Process
					{
						StartInfo = new ProcessStartInfo
						{
							FileName = "cmd",
							Arguments = logcatArgument.ToString(),
							UseShellExecute = false,
							RedirectStandardOutput = true,
							CreateNoWindow = true
						}
					};
					logcatShell.Start();

					MessageBox.Show(ListBoxDevices.SelectedItem.ToString() + " 기기의 로그 초기화가 완료되었습니다.", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else
			{
				MessageBox.Show("기기를 선택해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ButtonADBLogFolderOpen_Click(object sender, EventArgs e)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(logDirectory);
			if (!directoryInfo.Exists)
				directoryInfo.Create();
			Process.Start("explorer.exe", logDirectory);
		}

		private void ListBoxDevices_DoubleClick(object sender, EventArgs e)
		{
			string scrcpyPath = Path.Combine(Environment.CurrentDirectory,"scrcpy","scrcpy.exe");
			if (ListBoxDevices.SelectedIndex != -1)
			{
				string adbArgument = $"-s {ListBoxDevices.SelectedItem} logcat -s Unity -T 10";
				Process.Start(adbPath, adbArgument);

				string scrcpyArgument = $"-s {ListBoxDevices.SelectedItem} --show-touches";
				Process.Start(scrcpyPath, scrcpyArgument);
			}
		}

		private void TrayIcon_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				return;
			}
			if (e.Button == MouseButtons.Right)
			{
				TrayIcon.ContextMenuStrip = ContextMenu;
			}
		}

		private void ToolStripMenuItem_Exit_Click(object sender, EventArgs e)
		{
			ExitProgram();
		}

		private void TextBoxProjectName_TextChanged(object sender, EventArgs e)
		{
			Program.configLoader.ProjectConfig.ProjectName = TextBoxProjectName.Text;
		}
	}
}
