using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace UnityGameLogger.Controls
{
	public partial class GameLauncher : UserControl
	{
		[DllImport("user32")]
		private static extern int SetWindowText(int hWnd, string lpString);
		[DllImport("user32")]
		private static extern int FindWindowA(string lpClasssName, string lpWindowName);

		private int _gameConfigSlot;
		public int GameConfigSlot
		{
			get { return _gameConfigSlot; }
			set { _gameConfigSlot = value; }
		}

		public GameLauncher()
		{
			InitializeComponent();
		}

		private void GameLauncher_Load(object sender, EventArgs e)
		{
			if (!DesignMode)
			{
				NumericUpDownGameExecuteCount.Text = Program.configLoader.GameConfigs[_gameConfigSlot].GameExecuteCount.ToString();
				TextBoxGameMemo.Text = Program.configLoader.GameConfigs[_gameConfigSlot].GameMemo;

				string gameFile = Program.configLoader.GameConfigs[_gameConfigSlot].GameFile;

				if (gameFile == "")
				{
					LabelGameFile.Text = "경로 미설정";
				}
				else
				{
					LabelGameFile.Text = gameFile;
				}
			}
		}

		private void ButtonStartGame_Click(object sender, EventArgs e)
		{
			int gameExecuteCount = 1;

			string timeStamp = DateTime.Now.ToString("yyyy-MM-dd_HHmmss");
			string filePath = Path.Combine(Program.configLoader.GameConfigs[_gameConfigSlot].GameDirectory, Program.configLoader.GameConfigs[_gameConfigSlot].GameFile);
			string fileName = Program.configLoader.GameConfigs[_gameConfigSlot].GameFile;

			if (!File.Exists(filePath))
			{
				MessageBox.Show("파일 경로를 다시 재지정해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			for (int i = 0; i < gameExecuteCount; i++)
			{
				StringBuilder unityLogArgument = new StringBuilder();
				unityLogArgument.Append("-Name \"Player" + (i + 1) + "\" ");
				unityLogArgument.Append("-logFile \"" + Program.configLoader.GameConfigs[_gameConfigSlot].GameDirectory + "\\log\\" + timeStamp + "_Player" + (i + 1) + ".log" + "\" ");
				unityLogArgument.Append("-crash-report-folder \"" + Program.configLoader.GameConfigs[_gameConfigSlot].GameDirectory + "\\log\\\"");
				Process.Start(filePath, unityLogArgument.ToString());

				Thread.Sleep(1000);

				int hWnd = FindWindowA(null, Program.configLoader.ProjectConfig.ProjectName);
				string windowText = $"File Name : {fileName} | LogFile : {timeStamp}_Player{i + 1}.log";
				SetWindowText(hWnd, windowText);

				Thread.Sleep(1000);
			}
		}

		private void ButtonGamePath_Click(object sender, EventArgs e)
		{
			CommonOpenFileDialog ofd = new CommonOpenFileDialog();
			ofd.Filters.Add(new CommonFileDialogFilter("Execute File", "*.exe"));
			ofd.Multiselect = false;

			if (ofd.ShowDialog() == CommonFileDialogResult.Ok)
			{
				string fileDirectory = Path.GetDirectoryName(ofd.FileName);
				string fileName = Path.GetFileName(ofd.FileName);

				Program.configLoader.GameConfigs[_gameConfigSlot].GameDirectory = fileDirectory;
				Program.configLoader.GameConfigs[_gameConfigSlot].GameFile = fileName;
			}
		}

		private void ButtonOpenGameLogFolder_Click(object sender, EventArgs e)
		{
			string logFolder = Path.Combine(Program.configLoader.GameConfigs[_gameConfigSlot].GameDirectory, "log");
			Process.Start("explorer.exe", logFolder);
		}

		private void NumericUpDownGameExecuteCount_ValueChanged(object sender, EventArgs e)
		{
			int gameExecuteCount = int.Parse(NumericUpDownGameExecuteCount.Value.ToString());
			Program.configLoader.GameConfigs[_gameConfigSlot].GameExecuteCount = gameExecuteCount;
		}

		private void TextBoxGameMemo_TextChanged(object sender, EventArgs e)
		{
			string gamemMemo = TextBoxGameMemo.Text;
			Program.configLoader.GameConfigs[_gameConfigSlot].GameMemo = gamemMemo;
		}
	}
}
