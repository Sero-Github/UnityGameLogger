using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using UnityGameLogger.Config;

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
				ConfigLoader configLoader = ConfigLoader.Instance;
				NumericUpDownGameExecuteCount.Text = configLoader.GameConfigs[_gameConfigSlot].GameExecuteCount.ToString();
				TextBoxGameMemo.Text = configLoader.GameConfigs[_gameConfigSlot].GameMemo;

				string gameFile = configLoader.GameConfigs[_gameConfigSlot].GameFile;

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

			ConfigLoader configLoader = ConfigLoader.Instance;
			string timeStamp = DateTime.Now.ToString("yyyy-MM-dd_HHmmss");
			string filePath = Path.Combine(configLoader.GameConfigs[_gameConfigSlot].GameDirectory, configLoader.GameConfigs[_gameConfigSlot].GameFile);
			string fileName = configLoader.GameConfigs[_gameConfigSlot].GameFile;

			if (!File.Exists(filePath))
			{
				MessageBox.Show("파일 경로를 다시 재지정해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			for (int i = 0; i < gameExecuteCount; i++)
			{
				StringBuilder unityLogArgument = new StringBuilder();
				unityLogArgument.Append("-Name \"Player" + (i + 1) + "\" ");
				unityLogArgument.Append("-logFile \"" + configLoader.GameConfigs[_gameConfigSlot].GameDirectory + "\\log\\" + timeStamp + "_Player" + (i + 1) + ".log" + "\" ");
				unityLogArgument.Append("-crash-report-folder \"" + configLoader.GameConfigs[_gameConfigSlot].GameDirectory + "\\log\\\"");
				Process.Start(filePath, unityLogArgument.ToString());

				Thread.Sleep(1000);

				int hWnd = FindWindowA(null, configLoader.ProjectConfig.ProjectName);
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

				ConfigLoader configLoader = ConfigLoader.Instance;
				configLoader.GameConfigs[_gameConfigSlot].GameDirectory = fileDirectory;
				configLoader.GameConfigs[_gameConfigSlot].GameFile = fileName;

				LabelGameFile.Text = fileName;
			}
		}

		private void ButtonOpenGameLogFolder_Click(object sender, EventArgs e)
		{
			ConfigLoader configLoader = ConfigLoader.Instance;
			string logFolder = Path.Combine(configLoader.GameConfigs[_gameConfigSlot].GameDirectory, "log");
			Process.Start("explorer.exe", logFolder);
		}

		private void NumericUpDownGameExecuteCount_ValueChanged(object sender, EventArgs e)
		{
			int gameExecuteCount = int.Parse(NumericUpDownGameExecuteCount.Value.ToString());
			ConfigLoader configLoader = ConfigLoader.Instance;
			configLoader.GameConfigs[_gameConfigSlot].GameExecuteCount = gameExecuteCount;
		}

		private void TextBoxGameMemo_TextChanged(object sender, EventArgs e)
		{
			string gamemMemo = TextBoxGameMemo.Text;
			ConfigLoader configLoader = ConfigLoader.Instance;
			configLoader.GameConfigs[_gameConfigSlot].GameMemo = gamemMemo;
		}
	}
}
