namespace UnityGameLogger
{
	partial class SettingForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
			this.ButtonLogPath1 = new System.Windows.Forms.Button();
			this.LabelLogPath1 = new System.Windows.Forms.Label();
			this.LabelGamePath = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ButtonGamePath = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.ButtonClose = new System.Windows.Forms.Button();
			this.ButtonSetStartProgram = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.ButtonLogPath2 = new System.Windows.Forms.Button();
			this.LabelLogPath2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ButtonLogPath1
			// 
			this.ButtonLogPath1.Location = new System.Drawing.Point(96, 8);
			this.ButtonLogPath1.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonLogPath1.Name = "ButtonLogPath1";
			this.ButtonLogPath1.Size = new System.Drawing.Size(76, 23);
			this.ButtonLogPath1.TabIndex = 0;
			this.ButtonLogPath1.Text = "경로 설정";
			this.ButtonLogPath1.UseVisualStyleBackColor = true;
			this.ButtonLogPath1.Click += new System.EventHandler(this.ButtonLogPath1_Click);
			// 
			// LabelLogPath1
			// 
			this.LabelLogPath1.Location = new System.Drawing.Point(16, 40);
			this.LabelLogPath1.Name = "LabelLogPath1";
			this.LabelLogPath1.Size = new System.Drawing.Size(544, 16);
			this.LabelLogPath1.TabIndex = 1;
			this.LabelLogPath1.Text = "C:\\Users\\Sero\\AppData\\LocalLow\\DefaultCompany\\My project";
			// 
			// LabelGamePath
			// 
			this.LabelGamePath.Location = new System.Drawing.Point(16, 136);
			this.LabelGamePath.Name = "LabelGamePath";
			this.LabelGamePath.Size = new System.Drawing.Size(544, 16);
			this.LabelGamePath.TabIndex = 1;
			this.LabelGamePath.Text = "C:\\Users\\Sero\\AppData\\LocalLow\\DefaultCompany\\My project";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "로그 경로1";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ButtonGamePath
			// 
			this.ButtonGamePath.Location = new System.Drawing.Point(96, 104);
			this.ButtonGamePath.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonGamePath.Name = "ButtonGamePath";
			this.ButtonGamePath.Size = new System.Drawing.Size(76, 23);
			this.ButtonGamePath.TabIndex = 0;
			this.ButtonGamePath.Text = "경로 설정";
			this.ButtonGamePath.UseVisualStyleBackColor = true;
			this.ButtonGamePath.Click += new System.EventHandler(this.ButtonGamePath_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 104);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "게임 경로1";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ButtonClose
			// 
			this.ButtonClose.Location = new System.Drawing.Point(248, 192);
			this.ButtonClose.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonClose.Name = "ButtonClose";
			this.ButtonClose.Size = new System.Drawing.Size(76, 24);
			this.ButtonClose.TabIndex = 0;
			this.ButtonClose.Text = "닫기";
			this.ButtonClose.UseVisualStyleBackColor = true;
			this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
			// 
			// ButtonSetStartProgram
			// 
			this.ButtonSetStartProgram.Location = new System.Drawing.Point(16, 160);
			this.ButtonSetStartProgram.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonSetStartProgram.Name = "ButtonSetStartProgram";
			this.ButtonSetStartProgram.Size = new System.Drawing.Size(544, 24);
			this.ButtonSetStartProgram.TabIndex = 4;
			this.ButtonSetStartProgram.Text = "Unity Game Logger를 시작 프로그램으로 등록";
			this.ButtonSetStartProgram.UseVisualStyleBackColor = true;
			this.ButtonSetStartProgram.Click += new System.EventHandler(this.ButtonSetStartProgram_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(176, 104);
			this.button1.Margin = new System.Windows.Forms.Padding(0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(152, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Steam 경로로 자동 설정";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			this.button1.Click += new System.EventHandler(this.ButtonGamePath_Click);
			// 
			// ButtonLogPath2
			// 
			this.ButtonLogPath2.Location = new System.Drawing.Point(96, 56);
			this.ButtonLogPath2.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonLogPath2.Name = "ButtonLogPath2";
			this.ButtonLogPath2.Size = new System.Drawing.Size(76, 23);
			this.ButtonLogPath2.TabIndex = 0;
			this.ButtonLogPath2.Text = "경로 설정";
			this.ButtonLogPath2.UseVisualStyleBackColor = true;
			this.ButtonLogPath2.Click += new System.EventHandler(this.ButtonLogPath2_Click);
			// 
			// LabelLogPath2
			// 
			this.LabelLogPath2.Location = new System.Drawing.Point(16, 88);
			this.LabelLogPath2.Name = "LabelLogPath2";
			this.LabelLogPath2.Size = new System.Drawing.Size(544, 16);
			this.LabelLogPath2.TabIndex = 1;
			this.LabelLogPath2.Text = "C:\\Users\\Sero\\AppData\\LocalLow\\DefaultCompany\\My project";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 56);
			this.label4.Margin = new System.Windows.Forms.Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 24);
			this.label4.TabIndex = 1;
			this.label4.Text = "로그 경로2";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(176, 56);
			this.button4.Margin = new System.Windows.Forms.Padding(0);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(152, 23);
			this.button4.TabIndex = 0;
			this.button4.Text = "기본 로그 폴더로 설정";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Visible = false;
			this.button4.Click += new System.EventHandler(this.ButtonGamePath_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(176, 8);
			this.button2.Margin = new System.Windows.Forms.Padding(0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(152, 23);
			this.button2.TabIndex = 0;
			this.button2.Text = "기본 로그 폴더로 설정";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Visible = false;
			this.button2.Click += new System.EventHandler(this.ButtonGamePath_Click);
			// 
			// SettingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(568, 226);
			this.Controls.Add(this.ButtonSetStartProgram);
			this.Controls.Add(this.LabelGamePath);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.ButtonClose);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.LabelLogPath2);
			this.Controls.Add(this.ButtonGamePath);
			this.Controls.Add(this.ButtonLogPath2);
			this.Controls.Add(this.LabelLogPath1);
			this.Controls.Add(this.ButtonLogPath1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SettingForm";
			this.Text = "설정";
			this.Load += new System.EventHandler(this.SettingForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button ButtonLogPath1;
		private System.Windows.Forms.Label LabelLogPath1;
		private System.Windows.Forms.Label LabelGamePath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button ButtonGamePath;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button ButtonClose;
		private System.Windows.Forms.Button ButtonSetStartProgram;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button ButtonLogPath2;
		private System.Windows.Forms.Label LabelLogPath2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button2;
	}
}