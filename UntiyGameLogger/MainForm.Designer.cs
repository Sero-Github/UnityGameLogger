namespace UnityGameLogger
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
			this.ButtonOpenGameLogFolder1 = new System.Windows.Forms.Button();
			this.LabelSplitter1 = new System.Windows.Forms.Label();
			this.ButtonStartGame1 = new System.Windows.Forms.Button();
			this.LabelCountText1 = new System.Windows.Forms.Label();
			this.LabelSplitter2 = new System.Windows.Forms.Label();
			this.LabelGameFile1 = new System.Windows.Forms.Label();
			this.ButtonGamePath1 = new System.Windows.Forms.Button();
			this.NumericUpDownGameExecuteCount1 = new System.Windows.Forms.NumericUpDown();
			this.ButtonHelpPage = new System.Windows.Forms.Button();
			this.TextBoxGameMemo1 = new System.Windows.Forms.TextBox();
			this.TextBoxGameMemo2 = new System.Windows.Forms.TextBox();
			this.NumericUpDownGameExecuteCount2 = new System.Windows.Forms.NumericUpDown();
			this.LabelSplitter3 = new System.Windows.Forms.Label();
			this.LabelGameFile2 = new System.Windows.Forms.Label();
			this.LabelCountText2 = new System.Windows.Forms.Label();
			this.ButtonGamePath2 = new System.Windows.Forms.Button();
			this.ButtonStartGame2 = new System.Windows.Forms.Button();
			this.ButtonStartGame3 = new System.Windows.Forms.Button();
			this.ButtonGamePath3 = new System.Windows.Forms.Button();
			this.LabelCountText3 = new System.Windows.Forms.Label();
			this.LabelGameFile3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.NumericUpDownGameExecuteCount3 = new System.Windows.Forms.NumericUpDown();
			this.TextBoxGameMemo3 = new System.Windows.Forms.TextBox();
			this.ButtonOpenGameLogFolder2 = new System.Windows.Forms.Button();
			this.ButtonOpenGameLogFolder3 = new System.Windows.Forms.Button();
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
			((System.ComponentModel.ISupportInitialize)(this.NumericUpDownGameExecuteCount1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericUpDownGameExecuteCount2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericUpDownGameExecuteCount3)).BeginInit();
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
			this.ButtonOpenLogFolder1.Location = new System.Drawing.Point(182, 48);
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
			this.ButtonSetting.Location = new System.Drawing.Point(360, 301);
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
			this.LabelProgramInfo.Location = new System.Drawing.Point(8, 364);
			this.LabelProgramInfo.Margin = new System.Windows.Forms.Padding(0);
			this.LabelProgramInfo.Name = "LabelProgramInfo";
			this.LabelProgramInfo.Size = new System.Drawing.Size(520, 32);
			this.LabelProgramInfo.TabIndex = 0;
			this.LabelProgramInfo.Text = "Dev Sero-Github sero.developer@gmail.com\r\nVer 1.2.0 240317";
			this.LabelProgramInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ButtonQuitProgram
			// 
			this.ButtonQuitProgram.Location = new System.Drawing.Point(360, 325);
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
			// ButtonOpenGameLogFolder1
			// 
			this.ButtonOpenGameLogFolder1.Location = new System.Drawing.Point(232, 148);
			this.ButtonOpenGameLogFolder1.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonOpenGameLogFolder1.Name = "ButtonOpenGameLogFolder1";
			this.ButtonOpenGameLogFolder1.Size = new System.Drawing.Size(120, 24);
			this.ButtonOpenGameLogFolder1.TabIndex = 4;
			this.ButtonOpenGameLogFolder1.Text = "로그 폴더 열기";
			this.ButtonOpenGameLogFolder1.UseVisualStyleBackColor = true;
			this.ButtonOpenGameLogFolder1.Click += new System.EventHandler(this.ButtonOpenGameLogFolder1_Click);
			// 
			// LabelSplitter1
			// 
			this.LabelSplitter1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.LabelSplitter1.Font = new System.Drawing.Font("굴림", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.LabelSplitter1.Location = new System.Drawing.Point(8, 92);
			this.LabelSplitter1.MinimumSize = new System.Drawing.Size(1, 1);
			this.LabelSplitter1.Name = "LabelSplitter1";
			this.LabelSplitter1.Size = new System.Drawing.Size(344, 1);
			this.LabelSplitter1.TabIndex = 6;
			// 
			// ButtonStartGame1
			// 
			this.ButtonStartGame1.Location = new System.Drawing.Point(232, 100);
			this.ButtonStartGame1.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonStartGame1.Name = "ButtonStartGame1";
			this.ButtonStartGame1.Size = new System.Drawing.Size(120, 24);
			this.ButtonStartGame1.TabIndex = 2;
			this.ButtonStartGame1.Text = "게임 실행";
			this.ButtonStartGame1.UseVisualStyleBackColor = true;
			this.ButtonStartGame1.Click += new System.EventHandler(this.ButtonStartGame1_Click);
			// 
			// LabelCountText1
			// 
			this.LabelCountText1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.LabelCountText1.Location = new System.Drawing.Point(21, 100);
			this.LabelCountText1.Margin = new System.Windows.Forms.Padding(0);
			this.LabelCountText1.Name = "LabelCountText1";
			this.LabelCountText1.Size = new System.Drawing.Size(64, 24);
			this.LabelCountText1.TabIndex = 8;
			this.LabelCountText1.Text = "실행 대수";
			this.LabelCountText1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LabelSplitter2
			// 
			this.LabelSplitter2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.LabelSplitter2.Font = new System.Drawing.Font("굴림", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.LabelSplitter2.Location = new System.Drawing.Point(8, 180);
			this.LabelSplitter2.MinimumSize = new System.Drawing.Size(1, 1);
			this.LabelSplitter2.Name = "LabelSplitter2";
			this.LabelSplitter2.Size = new System.Drawing.Size(344, 1);
			this.LabelSplitter2.TabIndex = 9;
			// 
			// LabelGameFile1
			// 
			this.LabelGameFile1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.LabelGameFile1.Location = new System.Drawing.Point(8, 124);
			this.LabelGameFile1.Margin = new System.Windows.Forms.Padding(0);
			this.LabelGameFile1.Name = "LabelGameFile1";
			this.LabelGameFile1.Size = new System.Drawing.Size(216, 21);
			this.LabelGameFile1.TabIndex = 8;
			this.LabelGameFile1.Text = "경로 미설정";
			this.LabelGameFile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ButtonGamePath1
			// 
			this.ButtonGamePath1.Location = new System.Drawing.Point(232, 124);
			this.ButtonGamePath1.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonGamePath1.Name = "ButtonGamePath1";
			this.ButtonGamePath1.Size = new System.Drawing.Size(120, 24);
			this.ButtonGamePath1.TabIndex = 3;
			this.ButtonGamePath1.Text = "PC 빌드 경로 설정";
			this.ButtonGamePath1.UseVisualStyleBackColor = true;
			this.ButtonGamePath1.Click += new System.EventHandler(this.ButtonGamePath1_Click);
			// 
			// NumericUpDownGameExecuteCount1
			// 
			this.NumericUpDownGameExecuteCount1.Location = new System.Drawing.Point(88, 100);
			this.NumericUpDownGameExecuteCount1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.NumericUpDownGameExecuteCount1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NumericUpDownGameExecuteCount1.Name = "NumericUpDownGameExecuteCount1";
			this.NumericUpDownGameExecuteCount1.Size = new System.Drawing.Size(137, 21);
			this.NumericUpDownGameExecuteCount1.TabIndex = 5;
			this.NumericUpDownGameExecuteCount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.NumericUpDownGameExecuteCount1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NumericUpDownGameExecuteCount1.ValueChanged += new System.EventHandler(this.NumericUpDownGameExecuteCount1_ValueChanged);
			// 
			// ButtonHelpPage
			// 
			this.ButtonHelpPage.Location = new System.Drawing.Point(360, 277);
			this.ButtonHelpPage.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonHelpPage.Name = "ButtonHelpPage";
			this.ButtonHelpPage.Size = new System.Drawing.Size(168, 24);
			this.ButtonHelpPage.TabIndex = 22;
			this.ButtonHelpPage.Text = "GitHub Page";
			this.ButtonHelpPage.UseVisualStyleBackColor = true;
			this.ButtonHelpPage.Click += new System.EventHandler(this.ButtonHelpPage_Click);
			// 
			// TextBoxGameMemo1
			// 
			this.TextBoxGameMemo1.Location = new System.Drawing.Point(8, 148);
			this.TextBoxGameMemo1.Name = "TextBoxGameMemo1";
			this.TextBoxGameMemo1.Size = new System.Drawing.Size(216, 21);
			this.TextBoxGameMemo1.TabIndex = 6;
			this.TextBoxGameMemo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.TextBoxGameMemo1.TextChanged += new System.EventHandler(this.TextBoxGameMemo1_TextChanged);
			// 
			// TextBoxGameMemo2
			// 
			this.TextBoxGameMemo2.Location = new System.Drawing.Point(8, 236);
			this.TextBoxGameMemo2.Name = "TextBoxGameMemo2";
			this.TextBoxGameMemo2.Size = new System.Drawing.Size(217, 21);
			this.TextBoxGameMemo2.TabIndex = 11;
			this.TextBoxGameMemo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.TextBoxGameMemo2.TextChanged += new System.EventHandler(this.TextBoxGameMemo2_TextChanged);
			// 
			// NumericUpDownGameExecuteCount2
			// 
			this.NumericUpDownGameExecuteCount2.Location = new System.Drawing.Point(88, 188);
			this.NumericUpDownGameExecuteCount2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.NumericUpDownGameExecuteCount2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NumericUpDownGameExecuteCount2.Name = "NumericUpDownGameExecuteCount2";
			this.NumericUpDownGameExecuteCount2.Size = new System.Drawing.Size(137, 21);
			this.NumericUpDownGameExecuteCount2.TabIndex = 10;
			this.NumericUpDownGameExecuteCount2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.NumericUpDownGameExecuteCount2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NumericUpDownGameExecuteCount2.ValueChanged += new System.EventHandler(this.NumericUpDownGameExecuteCount2_ValueChanged);
			// 
			// LabelSplitter3
			// 
			this.LabelSplitter3.BackColor = System.Drawing.SystemColors.ControlDark;
			this.LabelSplitter3.Font = new System.Drawing.Font("굴림", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.LabelSplitter3.Location = new System.Drawing.Point(8, 268);
			this.LabelSplitter3.MinimumSize = new System.Drawing.Size(1, 1);
			this.LabelSplitter3.Name = "LabelSplitter3";
			this.LabelSplitter3.Size = new System.Drawing.Size(344, 1);
			this.LabelSplitter3.TabIndex = 16;
			// 
			// LabelGameFile2
			// 
			this.LabelGameFile2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.LabelGameFile2.Location = new System.Drawing.Point(8, 212);
			this.LabelGameFile2.Margin = new System.Windows.Forms.Padding(0);
			this.LabelGameFile2.Name = "LabelGameFile2";
			this.LabelGameFile2.Size = new System.Drawing.Size(216, 21);
			this.LabelGameFile2.TabIndex = 14;
			this.LabelGameFile2.Text = "경로 미설정";
			this.LabelGameFile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LabelCountText2
			// 
			this.LabelCountText2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.LabelCountText2.Location = new System.Drawing.Point(21, 188);
			this.LabelCountText2.Margin = new System.Windows.Forms.Padding(0);
			this.LabelCountText2.Name = "LabelCountText2";
			this.LabelCountText2.Size = new System.Drawing.Size(64, 24);
			this.LabelCountText2.TabIndex = 15;
			this.LabelCountText2.Text = "실행 대수";
			this.LabelCountText2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ButtonGamePath2
			// 
			this.ButtonGamePath2.Location = new System.Drawing.Point(232, 212);
			this.ButtonGamePath2.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonGamePath2.Name = "ButtonGamePath2";
			this.ButtonGamePath2.Size = new System.Drawing.Size(120, 24);
			this.ButtonGamePath2.TabIndex = 8;
			this.ButtonGamePath2.Text = "PC 빌드 경로 설정";
			this.ButtonGamePath2.UseVisualStyleBackColor = true;
			this.ButtonGamePath2.Click += new System.EventHandler(this.ButtonGamePath2_Click);
			// 
			// ButtonStartGame2
			// 
			this.ButtonStartGame2.Location = new System.Drawing.Point(232, 188);
			this.ButtonStartGame2.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonStartGame2.Name = "ButtonStartGame2";
			this.ButtonStartGame2.Size = new System.Drawing.Size(120, 24);
			this.ButtonStartGame2.TabIndex = 7;
			this.ButtonStartGame2.Text = "게임 실행";
			this.ButtonStartGame2.UseVisualStyleBackColor = true;
			this.ButtonStartGame2.Click += new System.EventHandler(this.ButtonStartGame2_Click);
			// 
			// ButtonStartGame3
			// 
			this.ButtonStartGame3.Location = new System.Drawing.Point(232, 276);
			this.ButtonStartGame3.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonStartGame3.Name = "ButtonStartGame3";
			this.ButtonStartGame3.Size = new System.Drawing.Size(120, 24);
			this.ButtonStartGame3.TabIndex = 12;
			this.ButtonStartGame3.Text = "게임 실행";
			this.ButtonStartGame3.UseVisualStyleBackColor = true;
			this.ButtonStartGame3.Click += new System.EventHandler(this.ButtonStartGame3_Click);
			// 
			// ButtonGamePath3
			// 
			this.ButtonGamePath3.Location = new System.Drawing.Point(232, 300);
			this.ButtonGamePath3.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonGamePath3.Name = "ButtonGamePath3";
			this.ButtonGamePath3.Size = new System.Drawing.Size(120, 24);
			this.ButtonGamePath3.TabIndex = 13;
			this.ButtonGamePath3.Text = "PC 빌드 경로 설정";
			this.ButtonGamePath3.UseVisualStyleBackColor = true;
			this.ButtonGamePath3.Click += new System.EventHandler(this.ButtonGamePath3_Click);
			// 
			// LabelCountText3
			// 
			this.LabelCountText3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.LabelCountText3.Location = new System.Drawing.Point(21, 276);
			this.LabelCountText3.Margin = new System.Windows.Forms.Padding(0);
			this.LabelCountText3.Name = "LabelCountText3";
			this.LabelCountText3.Size = new System.Drawing.Size(64, 24);
			this.LabelCountText3.TabIndex = 15;
			this.LabelCountText3.Text = "실행 대수";
			this.LabelCountText3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LabelGameFile3
			// 
			this.LabelGameFile3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.LabelGameFile3.Location = new System.Drawing.Point(8, 300);
			this.LabelGameFile3.Margin = new System.Windows.Forms.Padding(0);
			this.LabelGameFile3.Name = "LabelGameFile3";
			this.LabelGameFile3.Size = new System.Drawing.Size(216, 21);
			this.LabelGameFile3.TabIndex = 14;
			this.LabelGameFile3.Text = "경로 미설정";
			this.LabelGameFile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
			this.label6.Font = new System.Drawing.Font("굴림", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label6.Location = new System.Drawing.Point(8, 356);
			this.label6.MinimumSize = new System.Drawing.Size(1, 1);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(520, 1);
			this.label6.TabIndex = 16;
			// 
			// NumericUpDownGameExecuteCount3
			// 
			this.NumericUpDownGameExecuteCount3.Location = new System.Drawing.Point(88, 276);
			this.NumericUpDownGameExecuteCount3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.NumericUpDownGameExecuteCount3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NumericUpDownGameExecuteCount3.Name = "NumericUpDownGameExecuteCount3";
			this.NumericUpDownGameExecuteCount3.Size = new System.Drawing.Size(137, 21);
			this.NumericUpDownGameExecuteCount3.TabIndex = 15;
			this.NumericUpDownGameExecuteCount3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.NumericUpDownGameExecuteCount3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NumericUpDownGameExecuteCount3.ValueChanged += new System.EventHandler(this.NumericUpDownGameExecuteCount3_ValueChanged);
			// 
			// TextBoxGameMemo3
			// 
			this.TextBoxGameMemo3.Location = new System.Drawing.Point(8, 324);
			this.TextBoxGameMemo3.Name = "TextBoxGameMemo3";
			this.TextBoxGameMemo3.Size = new System.Drawing.Size(217, 21);
			this.TextBoxGameMemo3.TabIndex = 16;
			this.TextBoxGameMemo3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.TextBoxGameMemo3.TextChanged += new System.EventHandler(this.TextBoxGameMemo3_TextChanged);
			// 
			// ButtonOpenGameLogFolder2
			// 
			this.ButtonOpenGameLogFolder2.Location = new System.Drawing.Point(232, 236);
			this.ButtonOpenGameLogFolder2.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonOpenGameLogFolder2.Name = "ButtonOpenGameLogFolder2";
			this.ButtonOpenGameLogFolder2.Size = new System.Drawing.Size(120, 24);
			this.ButtonOpenGameLogFolder2.TabIndex = 9;
			this.ButtonOpenGameLogFolder2.Text = "로그 폴더 열기";
			this.ButtonOpenGameLogFolder2.UseVisualStyleBackColor = true;
			this.ButtonOpenGameLogFolder2.Click += new System.EventHandler(this.ButtonOpenGameLogFolder2_Click);
			// 
			// ButtonOpenGameLogFolder3
			// 
			this.ButtonOpenGameLogFolder3.Location = new System.Drawing.Point(232, 324);
			this.ButtonOpenGameLogFolder3.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonOpenGameLogFolder3.Name = "ButtonOpenGameLogFolder3";
			this.ButtonOpenGameLogFolder3.Size = new System.Drawing.Size(120, 24);
			this.ButtonOpenGameLogFolder3.TabIndex = 14;
			this.ButtonOpenGameLogFolder3.Text = "로그 폴더 열기";
			this.ButtonOpenGameLogFolder3.UseVisualStyleBackColor = true;
			this.ButtonOpenGameLogFolder3.Click += new System.EventHandler(this.ButtonOpenGameLogFolder3_Click);
			// 
			// ButtonADBDevice
			// 
			this.ButtonADBDevice.Location = new System.Drawing.Point(360, 164);
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
			this.ListBoxDevices.Location = new System.Drawing.Point(360, 50);
			this.ListBoxDevices.Name = "ListBoxDevices";
			this.ListBoxDevices.Size = new System.Drawing.Size(168, 112);
			this.ListBoxDevices.TabIndex = 17;
			this.ListBoxDevices.DoubleClick += new System.EventHandler(this.ListBoxDevices_DoubleClick);
			// 
			// ButtonADBLogExtract
			// 
			this.ButtonADBLogExtract.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.ButtonADBLogExtract.Location = new System.Drawing.Point(360, 188);
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
			this.ButtonADBLogClear.Location = new System.Drawing.Point(360, 212);
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
			this.LabelSplitter4.Location = new System.Drawing.Point(360, 268);
			this.LabelSplitter4.MinimumSize = new System.Drawing.Size(1, 1);
			this.LabelSplitter4.Name = "LabelSplitter4";
			this.LabelSplitter4.Size = new System.Drawing.Size(168, 1);
			this.LabelSplitter4.TabIndex = 20;
			// 
			// ButtonADBLogFolderOpen
			// 
			this.ButtonADBLogFolderOpen.Location = new System.Drawing.Point(360, 236);
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
			this.LabelProjectName.Size = new System.Drawing.Size(171, 15);
			this.LabelProjectName.TabIndex = 25;
			this.LabelProjectName.Text = "프로젝트 이름";
			this.LabelProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TextBoxProjectName
			// 
			this.TextBoxProjectName.Location = new System.Drawing.Point(8, 63);
			this.TextBoxProjectName.Name = "TextBoxProjectName";
			this.TextBoxProjectName.Size = new System.Drawing.Size(171, 21);
			this.TextBoxProjectName.TabIndex = 1;
			this.TextBoxProjectName.TextChanged += new System.EventHandler(this.TextBoxProjectName_TextChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 402);
			this.Controls.Add(this.TextBoxProjectName);
			this.Controls.Add(this.LabelProjectName);
			this.Controls.Add(this.LabelSplitter4);
			this.Controls.Add(this.ListBoxDevices);
			this.Controls.Add(this.TextBoxGameMemo3);
			this.Controls.Add(this.TextBoxGameMemo2);
			this.Controls.Add(this.NumericUpDownGameExecuteCount3);
			this.Controls.Add(this.NumericUpDownGameExecuteCount2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.LabelSplitter3);
			this.Controls.Add(this.LabelGameFile3);
			this.Controls.Add(this.LabelGameFile2);
			this.Controls.Add(this.LabelCountText3);
			this.Controls.Add(this.ButtonGamePath3);
			this.Controls.Add(this.LabelCountText2);
			this.Controls.Add(this.ButtonStartGame3);
			this.Controls.Add(this.ButtonGamePath2);
			this.Controls.Add(this.ButtonStartGame2);
			this.Controls.Add(this.TextBoxGameMemo1);
			this.Controls.Add(this.NumericUpDownGameExecuteCount1);
			this.Controls.Add(this.LabelSplitter2);
			this.Controls.Add(this.LabelGameFile1);
			this.Controls.Add(this.LabelCountText1);
			this.Controls.Add(this.LabelSplitter1);
			this.Controls.Add(this.ButtonGamePath1);
			this.Controls.Add(this.ButtonStartGame1);
			this.Controls.Add(this.ButtonOpenGameLogFolder3);
			this.Controls.Add(this.ButtonOpenGameLogFolder2);
			this.Controls.Add(this.ButtonOpenGameLogFolder1);
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
			((System.ComponentModel.ISupportInitialize)(this.NumericUpDownGameExecuteCount1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericUpDownGameExecuteCount2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericUpDownGameExecuteCount3)).EndInit();
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
		private System.Windows.Forms.Button ButtonOpenGameLogFolder1;
		private System.Windows.Forms.Label LabelSplitter1;
		private System.Windows.Forms.Button ButtonStartGame1;
		private System.Windows.Forms.Label LabelCountText1;
		private System.Windows.Forms.Label LabelSplitter2;
        private System.Windows.Forms.Label LabelGameFile1;
        private System.Windows.Forms.Button ButtonGamePath1;
        private System.Windows.Forms.NumericUpDown NumericUpDownGameExecuteCount1;
        private System.Windows.Forms.Button ButtonHelpPage;
		private System.Windows.Forms.TextBox TextBoxGameMemo1;
		private System.Windows.Forms.TextBox TextBoxGameMemo2;
		private System.Windows.Forms.NumericUpDown NumericUpDownGameExecuteCount2;
		private System.Windows.Forms.Label LabelSplitter3;
		private System.Windows.Forms.Label LabelGameFile2;
		private System.Windows.Forms.Label LabelCountText2;
		private System.Windows.Forms.Button ButtonGamePath2;
		private System.Windows.Forms.Button ButtonStartGame2;
		private System.Windows.Forms.Button ButtonStartGame3;
		private System.Windows.Forms.Button ButtonGamePath3;
		private System.Windows.Forms.Label LabelCountText3;
		private System.Windows.Forms.Label LabelGameFile3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown NumericUpDownGameExecuteCount3;
		private System.Windows.Forms.TextBox TextBoxGameMemo3;
		private System.Windows.Forms.Button ButtonOpenGameLogFolder2;
		private System.Windows.Forms.Button ButtonOpenGameLogFolder3;
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
	}
}

