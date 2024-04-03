namespace UnityGameLogger.Controls
{
	partial class GameLauncher
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

		#region 구성 요소 디자이너에서 생성한 코드

		/// <summary> 
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.TextBoxGameMemo = new System.Windows.Forms.TextBox();
			this.NumericUpDownGameExecuteCount = new System.Windows.Forms.NumericUpDown();
			this.LabelGameFile = new System.Windows.Forms.Label();
			this.LabelCountText = new System.Windows.Forms.Label();
			this.ButtonGamePath = new System.Windows.Forms.Button();
			this.ButtonStartGame = new System.Windows.Forms.Button();
			this.ButtonOpenGameLogFolder = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.NumericUpDownGameExecuteCount)).BeginInit();
			this.SuspendLayout();
			// 
			// TextBoxGameMemo
			// 
			this.TextBoxGameMemo.Location = new System.Drawing.Point(0, 51);
			this.TextBoxGameMemo.Name = "TextBoxGameMemo";
			this.TextBoxGameMemo.Size = new System.Drawing.Size(216, 21);
			this.TextBoxGameMemo.TabIndex = 13;
			this.TextBoxGameMemo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.TextBoxGameMemo.TextChanged += new System.EventHandler(this.TextBoxGameMemo_TextChanged);
			// 
			// NumericUpDownGameExecuteCount
			// 
			this.NumericUpDownGameExecuteCount.Location = new System.Drawing.Point(64, 1);
			this.NumericUpDownGameExecuteCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.NumericUpDownGameExecuteCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NumericUpDownGameExecuteCount.Name = "NumericUpDownGameExecuteCount";
			this.NumericUpDownGameExecuteCount.Size = new System.Drawing.Size(152, 21);
			this.NumericUpDownGameExecuteCount.TabIndex = 12;
			this.NumericUpDownGameExecuteCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.NumericUpDownGameExecuteCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NumericUpDownGameExecuteCount.ValueChanged += new System.EventHandler(this.NumericUpDownGameExecuteCount_ValueChanged);
			// 
			// LabelGameFile
			// 
			this.LabelGameFile.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.LabelGameFile.Location = new System.Drawing.Point(0, 25);
			this.LabelGameFile.Margin = new System.Windows.Forms.Padding(0);
			this.LabelGameFile.Name = "LabelGameFile";
			this.LabelGameFile.Size = new System.Drawing.Size(216, 21);
			this.LabelGameFile.TabIndex = 14;
			this.LabelGameFile.Text = "경로 미설정";
			this.LabelGameFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LabelCountText
			// 
			this.LabelCountText.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.LabelCountText.Location = new System.Drawing.Point(0, 1);
			this.LabelCountText.Margin = new System.Windows.Forms.Padding(0);
			this.LabelCountText.Name = "LabelCountText";
			this.LabelCountText.Size = new System.Drawing.Size(61, 21);
			this.LabelCountText.TabIndex = 15;
			this.LabelCountText.Text = "실행 대수";
			this.LabelCountText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ButtonGamePath
			// 
			this.ButtonGamePath.Location = new System.Drawing.Point(219, 25);
			this.ButtonGamePath.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonGamePath.Name = "ButtonGamePath";
			this.ButtonGamePath.Size = new System.Drawing.Size(120, 24);
			this.ButtonGamePath.TabIndex = 10;
			this.ButtonGamePath.Text = "PC 빌드 경로 설정";
			this.ButtonGamePath.UseVisualStyleBackColor = true;
			this.ButtonGamePath.Click += new System.EventHandler(this.ButtonGamePath_Click);
			// 
			// ButtonStartGame
			// 
			this.ButtonStartGame.Location = new System.Drawing.Point(219, 0);
			this.ButtonStartGame.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonStartGame.Name = "ButtonStartGame";
			this.ButtonStartGame.Size = new System.Drawing.Size(120, 24);
			this.ButtonStartGame.TabIndex = 9;
			this.ButtonStartGame.Text = "게임 실행";
			this.ButtonStartGame.UseVisualStyleBackColor = true;
			this.ButtonStartGame.Click += new System.EventHandler(this.ButtonStartGame_Click);
			// 
			// ButtonOpenGameLogFolder
			// 
			this.ButtonOpenGameLogFolder.Location = new System.Drawing.Point(219, 49);
			this.ButtonOpenGameLogFolder.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonOpenGameLogFolder.Name = "ButtonOpenGameLogFolder";
			this.ButtonOpenGameLogFolder.Size = new System.Drawing.Size(120, 24);
			this.ButtonOpenGameLogFolder.TabIndex = 11;
			this.ButtonOpenGameLogFolder.Text = "로그 폴더 열기";
			this.ButtonOpenGameLogFolder.UseVisualStyleBackColor = true;
			this.ButtonOpenGameLogFolder.Click += new System.EventHandler(this.ButtonOpenGameLogFolder_Click);
			// 
			// GameLauncher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.TextBoxGameMemo);
			this.Controls.Add(this.NumericUpDownGameExecuteCount);
			this.Controls.Add(this.LabelGameFile);
			this.Controls.Add(this.LabelCountText);
			this.Controls.Add(this.ButtonGamePath);
			this.Controls.Add(this.ButtonStartGame);
			this.Controls.Add(this.ButtonOpenGameLogFolder);
			this.MaximumSize = new System.Drawing.Size(338, 73);
			this.MinimumSize = new System.Drawing.Size(338, 73);
			this.Name = "GameLauncher";
			this.Size = new System.Drawing.Size(338, 73);
			this.Load += new System.EventHandler(this.GameLauncher_Load);
			((System.ComponentModel.ISupportInitialize)(this.NumericUpDownGameExecuteCount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TextBoxGameMemo;
		private System.Windows.Forms.NumericUpDown NumericUpDownGameExecuteCount;
		private System.Windows.Forms.Label LabelGameFile;
		private System.Windows.Forms.Label LabelCountText;
		private System.Windows.Forms.Button ButtonGamePath;
		private System.Windows.Forms.Button ButtonStartGame;
		private System.Windows.Forms.Button ButtonOpenGameLogFolder;
	}
}
