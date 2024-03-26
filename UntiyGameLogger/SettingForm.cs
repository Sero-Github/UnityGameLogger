using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace UnityGameLogger
{
	public partial class SettingForm : Form
    {
        private readonly string _startupRegPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
        private readonly string _programName = @"UnityGameLogger";

        public SettingForm()
		{
			InitializeComponent();

            using (RegistryKey regKey = Registry.CurrentUser.OpenSubKey(_startupRegPath, true))
            {
                try
                {
                    if (regKey.GetValue(_programName) == null)
                    {
                        ButtonSetStartProgram.Text = "Unity Game Logger를 시작 프로그램으로 등록";
                    }
                    else
                    {
                        ButtonSetStartProgram.Text = "Unity Game Logger를 시작 프로그램으로 해제";
                    }
                    regKey.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

		private void ButtonClose_Click(object sender, EventArgs e)
		{
			this.Close();
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

				LabelGamePath.Text = fileDirectory;
                Program.configLoader.GameConfigs[0].GameDirectory = fileDirectory;
                Program.configLoader.GameConfigs[0].GameFile = fileName;
			}
		}
		private void ButtonLogPath1_Click(object sender, EventArgs e)
		{
			CommonOpenFileDialog ofd = new CommonOpenFileDialog
			{
				IsFolderPicker = true,
				Multiselect = false
			};
			if (ofd.ShowDialog() == CommonFileDialogResult.Ok)
			{
				LabelLogPath1.Text = ofd.FileName;
				Program.configLoader.LogConfigs[0].LogDirectory = ofd.FileName;
			}
		}

		private void ButtonLogPath2_Click(object sender, EventArgs e)
		{
			CommonOpenFileDialog ofd = new CommonOpenFileDialog
			{
				IsFolderPicker = true,
				Multiselect = false
			};

			if (ofd.ShowDialog() == CommonFileDialogResult.Ok)
			{
				LabelLogPath2.Text = ofd.FileName;
				Program.configLoader.LogConfigs[1].LogDirectory = ofd.FileName;
			}
		}

		private void SettingForm_Load(object sender, EventArgs e)
		{
			LabelLogPath1.Text = Program.configLoader.LogConfigs[0].LogDirectory;
			LabelLogPath2.Text = Program.configLoader.LogConfigs[1].LogDirectory;
			LabelGamePath.Text = Program.configLoader.GameConfigs[0].GameDirectory;
		}

        private void ButtonSetStartProgram_Click(object sender, EventArgs e)
        {
            using (RegistryKey regKey = Registry.CurrentUser.OpenSubKey(_startupRegPath, true))
            {
                try
                {
                    if (regKey.GetValue(_programName) == null)
                    {
                        regKey.SetValue(_programName, Application.ExecutablePath);
						ButtonSetStartProgram.Text = "Unity Game Logger를 시작 프로그램으로 해제";
					}
                    else
                    {
                        regKey.DeleteValue(_programName, false);
						ButtonSetStartProgram.Text = "Unity Game Logger를 시작 프로그램으로 등록";
					}
                    regKey.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
	}
}
