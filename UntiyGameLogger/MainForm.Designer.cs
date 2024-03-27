﻿namespace UnityGameLogger
{
	partial class MainForm
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.LabelTitle = new System.Windows.Forms.Label();
			this.ButtonOpenLogFolder1 = new System.Windows.Forms.Button();
			this.ButtonSetting = new System.Windows.Forms.Button();
			this.LabelProgramInfo = new System.Windows.Forms.Label();
			this.ButtonQuitProgram = new System.Windows.Forms.Button();
			this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.LabelSplitter1 = new System.Windows.Forms.Label();
			this.LabelSplitter2 = new System.Windows.Forms.Label();
			this.ButtonHelpPage = new System.Windows.Forms.Button();
			this.LabelSplitter3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.ButtonADBDevice = new System.Windows.Forms.Button();
			this.ListBoxDevices = new System.Windows.Forms.ListBox();
			this.ButtonADBLogExtract = new System.Windows.Forms.Button();
			this.ButtonADBLogClear = new System.Windows.Forms.Button();
			this.LabelSplitter4 = new System.Windows.Forms.Label();
			this.ButtonADBLogFolderOpen = new System.Windows.Forms.Button();
			this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ToolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
			this.LabelProjectName = new System.Windows.Forms.Label();
			this.TextBoxProjectName = new System.Windows.Forms.TextBox();
			this.gameLauncher1 = new UnityGameLogger.Controls.GameLauncher();
			this.gameLauncher2 = new UnityGameLogger.Controls.GameLauncher();
			this.gameLauncher3 = new UnityGameLogger.Controls.GameLauncher();
			this.ContextMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// LabelTitle
			// 
			this.LabelTitle.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.LabelTitle.Location = new System.Drawing.Point(8, 8);
			this.LabelTitle.Margin = new System.Windows.Forms.Padding(0);
			this.LabelTitle.Name = "LabelTitle";
			this.LabelTitle.Size = new System.Drawing.Size(520, 25);
			this.LabelTitle.TabIndex = 0;
			this.LabelTitle.Text = "Unity Game Logger";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ButtonOpenLogFolder1
			// 
			this.ButtonOpenLogFolder1.Location = new System.Drawing.Point(176, 45);
			this.ButtonOpenLogFolder1.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonOpenLogFolder1.Name = "ButtonOpenLogFolder1";
			this.ButtonOpenLogFolder1.Size = new System.Drawing.Size(170, 40);
			this.ButtonOpenLogFolder1.TabIndex = 2;
			this.ButtonOpenLogFolder1.Text = "로그 폴더 열기";
			this.ButtonOpenLogFolder1.UseVisualStyleBackColor = true;
			this.ButtonOpenLogFolder1.Click += new System.EventHandler(this.ButtonOpenLogFolder1_Click);
			// 
			// ButtonSetting
			// 
			this.ButtonSetting.Location = new System.Drawing.Point(352, 281);
			this.ButtonSetting.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonSetting.Name = "ButtonSetting";
			this.ButtonSetting.Size = new System.Drawing.Size(168, 24);
			this.ButtonSetting.TabIndex = 23;
			this.ButtonSetting.Text = "프로그램 설정";
			this.ButtonSetting.UseVisualStyleBackColor = true;
			this.ButtonSetting.Click += new System.EventHandler(this.ButtonSetting_Click);
			// 
			// LabelProgramInfo
			// 
			this.LabelProgramInfo.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.LabelProgramInfo.Location = new System.Drawing.Point(8, 334);
			this.LabelProgramInfo.Margin = new System.Windows.Forms.Padding(0);
			this.LabelProgramInfo.Name = "LabelProgramInfo";
			this.LabelProgramInfo.Size = new System.Drawing.Size(512, 32);
			this.LabelProgramInfo.TabIndex = 0;
			this.LabelProgramInfo.Text = "Dev Sero-Github sero.developer@gmail.com\r\nVer 1.2.0 240317";
			this.LabelProgramInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ButtonQuitProgram
			// 
			this.ButtonQuitProgram.Location = new System.Drawing.Point(352, 305);
			this.ButtonQuitProgram.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonQuitProgram.Name = "ButtonQuitProgram";
			this.ButtonQuitProgram.Size = new System.Drawing.Size(168, 24);
			this.ButtonQuitProgram.TabIndex = 24;
			this.ButtonQuitProgram.Text = "종료";
			this.ButtonQuitProgram.UseVisualStyleBackColor = true;
			this.ButtonQuitProgram.Click += new System.EventHandler(this.ButtonQuitProgram_Click);
			// 
			// TrayIcon
			// 
			this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
			this.TrayIcon.Text = "notifyIcon1";
			this.TrayIcon.Visible = true;
			this.TrayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseClick);
			this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
			// 
			// LabelSplitter1
			// 
			this.LabelSplitter1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.LabelSplitter1.Font = new System.Drawing.Font("굴림", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.LabelSplitter1.Location = new System.Drawing.Point(8, 92);
			this.LabelSplitter1.MinimumSize = new System.Drawing.Size(1, 1);
			this.LabelSplitter1.Name = "LabelSplitter1";
			this.LabelSplitter1.Size = new System.Drawing.Size(338, 1);
			this.LabelSplitter1.TabIndex = 6;
			// 
			// LabelSplitter2
			// 
			this.LabelSplitter2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.LabelSplitter2.Font = new System.Drawing.Font("굴림", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.LabelSplitter2.Location = new System.Drawing.Point(8, 172);
			this.LabelSplitter2.MinimumSize = new System.Drawing.Size(1, 1);
			this.LabelSplitter2.Name = "LabelSplitter2";
			this.LabelSplitter2.Size = new System.Drawing.Size(338, 1);
			this.LabelSplitter2.TabIndex = 9;
			// 
			// ButtonHelpPage
			// 
			this.ButtonHelpPage.Location = new System.Drawing.Point(352, 257);
			this.ButtonHelpPage.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonHelpPage.Name = "ButtonHelpPage";
			this.ButtonHelpPage.Size = new System.Drawing.Size(168, 24);
			this.ButtonHelpPage.TabIndex = 22;
			this.ButtonHelpPage.Text = "GitHub Page";
			this.ButtonHelpPage.UseVisualStyleBackColor = true;
			this.ButtonHelpPage.Click += new System.EventHandler(this.ButtonHelpPage_Click);
			// 
			// LabelSplitter3
			// 
			this.LabelSplitter3.BackColor = System.Drawing.SystemColors.ControlDark;
			this.LabelSplitter3.Font = new System.Drawing.Font("굴림", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.LabelSplitter3.Location = new System.Drawing.Point(8, 252);
			this.LabelSplitter3.MinimumSize = new System.Drawing.Size(1, 1);
			this.LabelSplitter3.Name = "LabelSplitter3";
			this.LabelSplitter3.Size = new System.Drawing.Size(338, 1);
			this.LabelSplitter3.TabIndex = 16;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
			this.label6.Font = new System.Drawing.Font("굴림", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label6.Location = new System.Drawing.Point(8, 332);
			this.label6.MinimumSize = new System.Drawing.Size(1, 1);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(511, 1);
			this.label6.TabIndex = 16;
			// 
			// ButtonADBDevice
			// 
			this.ButtonADBDevice.Location = new System.Drawing.Point(352, 153);
			this.ButtonADBDevice.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonADBDevice.Name = "ButtonADBDevice";
			this.ButtonADBDevice.Size = new System.Drawing.Size(168, 24);
			this.ButtonADBDevice.TabIndex = 18;
			this.ButtonADBDevice.Text = "ADB 기기 수동 검색";
			this.ButtonADBDevice.UseVisualStyleBackColor = true;
			this.ButtonADBDevice.Click += new System.EventHandler(this.ButtonADBDevice_Click);
			// 
			// ListBoxDevices
			// 
			this.ListBoxDevices.FormattingEnabled = true;
			this.ListBoxDevices.ItemHeight = 12;
			this.ListBoxDevices.Location = new System.Drawing.Point(352, 45);
			this.ListBoxDevices.Name = "ListBoxDevices";
			this.ListBoxDevices.Size = new System.Drawing.Size(168, 100);
			this.ListBoxDevices.TabIndex = 17;
			this.ListBoxDevices.DoubleClick += new System.EventHandler(this.ListBoxDevices_DoubleClick);
			// 
			// ButtonADBLogExtract
			// 
			this.ButtonADBLogExtract.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.ButtonADBLogExtract.Location = new System.Drawing.Point(352, 177);
			this.ButtonADBLogExtract.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonADBLogExtract.Name = "ButtonADBLogExtract";
			this.ButtonADBLogExtract.Size = new System.Drawing.Size(168, 24);
			this.ButtonADBLogExtract.TabIndex = 19;
			this.ButtonADBLogExtract.Text = "ADB LOG 추출";
			this.ButtonADBLogExtract.UseVisualStyleBackColor = true;
			this.ButtonADBLogExtract.Click += new System.EventHandler(this.ButtonADBExtract_Click);
			// 
			// ButtonADBLogClear
			// 
			this.ButtonADBLogClear.Location = new System.Drawing.Point(352, 201);
			this.ButtonADBLogClear.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonADBLogClear.Name = "ButtonADBLogClear";
			this.ButtonADBLogClear.Size = new System.Drawing.Size(168, 24);
			this.ButtonADBLogClear.TabIndex = 20;
			this.ButtonADBLogClear.Text = "ADB LOG 초기화";
			this.ButtonADBLogClear.UseVisualStyleBackColor = true;
			this.ButtonADBLogClear.Click += new System.EventHandler(this.ButtonADBLogClear_Click);
			// 
			// LabelSplitter4
			// 
			this.LabelSplitter4.BackColor = System.Drawing.SystemColors.ControlDark;
			this.LabelSplitter4.Font = new System.Drawing.Font("굴림", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.LabelSplitter4.Location = new System.Drawing.Point(353, 252);
			this.LabelSplitter4.MinimumSize = new System.Drawing.Size(1, 1);
			this.LabelSplitter4.Name = "LabelSplitter4";
			this.LabelSplitter4.Size = new System.Drawing.Size(166, 1);
			this.LabelSplitter4.TabIndex = 20;
			// 
			// ButtonADBLogFolderOpen
			// 
			this.ButtonADBLogFolderOpen.Location = new System.Drawing.Point(352, 225);
			this.ButtonADBLogFolderOpen.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonADBLogFolderOpen.Name = "ButtonADBLogFolderOpen";
			this.ButtonADBLogFolderOpen.Size = new System.Drawing.Size(168, 24);
			this.ButtonADBLogFolderOpen.TabIndex = 21;
			this.ButtonADBLogFolderOpen.Text = "ADB LOG 폴더 열기";
			this.ButtonADBLogFolderOpen.UseVisualStyleBackColor = true;
			this.ButtonADBLogFolderOpen.Click += new System.EventHandler(this.ButtonADBLogFolderOpen_Click);
			// 
			// ContextMenu
			// 
			this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Exit});
			this.ContextMenu.Name = "ContextMenu";
			this.ContextMenu.Size = new System.Drawing.Size(99, 26);
			// 
			// ToolStripMenuItem_Exit
			// 
			this.ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
			this.ToolStripMenuItem_Exit.Size = new System.Drawing.Size(98, 22);
			this.ToolStripMenuItem_Exit.Text = "종료";
			this.ToolStripMenuItem_Exit.Click += new System.EventHandler(this.ToolStripMenuItem_Exit_Click);
			// 
			// LabelProjectName
			// 
			this.LabelProjectName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.LabelProjectName.Location = new System.Drawing.Point(8, 45);
			this.LabelProjectName.Name = "LabelProjectName";
			this.LabelProjectName.Size = new System.Drawing.Size(165, 15);
			this.LabelProjectName.TabIndex = 25;
			this.LabelProjectName.Text = "프로젝트 이름";
			this.LabelProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TextBoxProjectName
			// 
			this.TextBoxProjectName.Location = new System.Drawing.Point(8, 63);
			this.TextBoxProjectName.Name = "TextBoxProjectName";
			this.TextBoxProjectName.Size = new System.Drawing.Size(165, 21);
			this.TextBoxProjectName.TabIndex = 1;
			this.TextBoxProjectName.TextChanged += new System.EventHandler(this.TextBoxProjectName_TextChanged);
			// 
			// gameLauncher1
			// 
			this.gameLauncher1.GameConfigSlot = 0;
			this.gameLauncher1.Location = new System.Drawing.Point(8, 96);
			this.gameLauncher1.MaximumSize = new System.Drawing.Size(338, 73);
			this.gameLauncher1.MinimumSize = new System.Drawing.Size(338, 73);
			this.gameLauncher1.Name = "gameLauncher1";
			this.gameLauncher1.Size = new System.Drawing.Size(338, 73);
			this.gameLauncher1.TabIndex = 26;
			// 
			// gameLauncher2
			// 
			this.gameLauncher2.GameConfigSlot = 1;
			this.gameLauncher2.Location = new System.Drawing.Point(8, 176);
			this.gameLauncher2.MaximumSize = new System.Drawing.Size(338, 73);
			this.gameLauncher2.MinimumSize = new System.Drawing.Size(338, 73);
			this.gameLauncher2.Name = "gameLauncher2";
			this.gameLauncher2.Size = new System.Drawing.Size(338, 73);
			this.gameLauncher2.TabIndex = 26;
			// 
			// gameLauncher3
			// 
			this.gameLauncher3.GameConfigSlot = 2;
			this.gameLauncher3.Location = new System.Drawing.Point(8, 256);
			this.gameLauncher3.MaximumSize = new System.Drawing.Size(338, 73);
			this.gameLauncher3.MinimumSize = new System.Drawing.Size(338, 73);
			this.gameLauncher3.Name = "gameLauncher3";
			this.gameLauncher3.Size = new System.Drawing.Size(338, 73);
			this.gameLauncher3.TabIndex = 26;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(528, 371);
			this.Controls.Add(this.gameLauncher3);
			this.Controls.Add(this.gameLauncher2);
			this.Controls.Add(this.gameLauncher1);
			this.Controls.Add(this.TextBoxProjectName);
			this.Controls.Add(this.LabelProjectName);
			this.Controls.Add(this.LabelSplitter4);
			this.Controls.Add(this.ListBoxDevices);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.LabelSplitter3);
			this.Controls.Add(this.LabelSplitter2);
			this.Controls.Add(this.LabelSplitter1);
			this.Controls.Add(this.ButtonQuitProgram);
			this.Controls.Add(this.ButtonHelpPage);
			this.Controls.Add(this.ButtonSetting);
			this.Controls.Add(this.ButtonADBLogFolderOpen);
			this.Controls.Add(this.ButtonADBLogClear);
			this.Controls.Add(this.ButtonADBLogExtract);
			this.Controls.Add(this.ButtonADBDevice);
			this.Controls.Add(this.ButtonOpenLogFolder1);
			this.Controls.Add(this.LabelProgramInfo);
			this.Controls.Add(this.LabelTitle);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Unity Game Logger";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ContextMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LabelTitle;
		private System.Windows.Forms.Button ButtonOpenLogFolder1;
		private System.Windows.Forms.Button ButtonSetting;
		private System.Windows.Forms.Label LabelProgramInfo;
		private System.Windows.Forms.Button ButtonQuitProgram;
		private System.Windows.Forms.NotifyIcon TrayIcon;
		private System.Windows.Forms.Label LabelSplitter1;
		private System.Windows.Forms.Label LabelSplitter2;
        private System.Windows.Forms.Button ButtonHelpPage;
		private System.Windows.Forms.Label LabelSplitter3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button ButtonADBDevice;
		private System.Windows.Forms.ListBox ListBoxDevices;
		private System.Windows.Forms.Button ButtonADBLogExtract;
		private System.Windows.Forms.Button ButtonADBLogClear;
		private System.Windows.Forms.Label LabelSplitter4;
		private System.Windows.Forms.Button ButtonADBLogFolderOpen;
		private new System.Windows.Forms.ContextMenuStrip ContextMenu;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Exit;
		private System.Windows.Forms.Label LabelProjectName;
		private System.Windows.Forms.TextBox TextBoxProjectName;
		private UnityGameLogger.Controls.GameLauncher gameLauncher1;
		private UnityGameLogger.Controls.GameLauncher gameLauncher2;
		private UnityGameLogger.Controls.GameLauncher gameLauncher3;
	}
}

