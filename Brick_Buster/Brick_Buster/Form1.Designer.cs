namespace Brick_Buster
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DiffH = new System.Windows.Forms.RadioButton();
            this.DiffGroup = new System.Windows.Forms.GroupBox();
            this.DiffEX = new System.Windows.Forms.RadioButton();
            this.DiffHow = new System.Windows.Forms.RadioButton();
            this.DiffE = new System.Windows.Forms.RadioButton();
            this.DiffN = new System.Windows.Forms.RadioButton();
            this.SpeedGroup = new System.Windows.Forms.GroupBox();
            this.SpeedH = new System.Windows.Forms.RadioButton();
            this.SpeedEX = new System.Windows.Forms.RadioButton();
            this.SpeedE = new System.Windows.Forms.RadioButton();
            this.StartBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.HighScoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.DiffGroup.SuspendLayout();
            this.SpeedGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Chartreuse;
            this.pictureBox1.Location = new System.Drawing.Point(815, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DiffH
            // 
            this.DiffH.AutoSize = true;
            this.DiffH.Location = new System.Drawing.Point(6, 74);
            this.DiffH.Name = "DiffH";
            this.DiffH.Size = new System.Drawing.Size(56, 19);
            this.DiffH.TabIndex = 1;
            this.DiffH.TabStop = true;
            this.DiffH.Text = "Hard";
            this.DiffH.UseVisualStyleBackColor = true;
            this.DiffH.CheckedChanged += new System.EventHandler(this.DiffH_CheckedChanged);
            // 
            // DiffGroup
            // 
            this.DiffGroup.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DiffGroup.Controls.Add(this.DiffEX);
            this.DiffGroup.Controls.Add(this.DiffHow);
            this.DiffGroup.Controls.Add(this.DiffE);
            this.DiffGroup.Controls.Add(this.DiffN);
            this.DiffGroup.Controls.Add(this.DiffH);
            this.DiffGroup.Location = new System.Drawing.Point(826, 12);
            this.DiffGroup.Name = "DiffGroup";
            this.DiffGroup.Size = new System.Drawing.Size(141, 154);
            this.DiffGroup.TabIndex = 2;
            this.DiffGroup.TabStop = false;
            this.DiffGroup.Text = "Difficulty";
            // 
            // DiffEX
            // 
            this.DiffEX.AutoSize = true;
            this.DiffEX.Location = new System.Drawing.Point(6, 124);
            this.DiffEX.Name = "DiffEX";
            this.DiffEX.Size = new System.Drawing.Size(59, 19);
            this.DiffEX.TabIndex = 5;
            this.DiffEX.TabStop = true;
            this.DiffEX.Text = "Extra";
            this.DiffEX.UseVisualStyleBackColor = true;
            this.DiffEX.CheckedChanged += new System.EventHandler(this.DiffEX_CheckedChanged);
            // 
            // DiffHow
            // 
            this.DiffHow.AutoSize = true;
            this.DiffHow.Location = new System.Drawing.Point(6, 99);
            this.DiffHow.Name = "DiffHow";
            this.DiffHow.Size = new System.Drawing.Size(131, 19);
            this.DiffHow.TabIndex = 4;
            this.DiffHow.TabStop = true;
            this.DiffHow.Text = "HOW TO PLAY?";
            this.DiffHow.UseVisualStyleBackColor = true;
            this.DiffHow.CheckedChanged += new System.EventHandler(this.DiffHow_CheckedChanged);
            // 
            // DiffE
            // 
            this.DiffE.AutoSize = true;
            this.DiffE.Location = new System.Drawing.Point(6, 24);
            this.DiffE.Name = "DiffE";
            this.DiffE.Size = new System.Drawing.Size(55, 19);
            this.DiffE.TabIndex = 3;
            this.DiffE.TabStop = true;
            this.DiffE.Text = "Easy";
            this.DiffE.UseVisualStyleBackColor = true;
            this.DiffE.CheckedChanged += new System.EventHandler(this.DiffE_CheckedChanged);
            // 
            // DiffN
            // 
            this.DiffN.AutoSize = true;
            this.DiffN.Location = new System.Drawing.Point(6, 49);
            this.DiffN.Name = "DiffN";
            this.DiffN.Size = new System.Drawing.Size(71, 19);
            this.DiffN.TabIndex = 2;
            this.DiffN.TabStop = true;
            this.DiffN.Text = "Normal";
            this.DiffN.UseVisualStyleBackColor = true;
            this.DiffN.CheckedChanged += new System.EventHandler(this.DiffN_CheckedChanged);
            // 
            // SpeedGroup
            // 
            this.SpeedGroup.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.SpeedGroup.Controls.Add(this.SpeedH);
            this.SpeedGroup.Controls.Add(this.SpeedEX);
            this.SpeedGroup.Controls.Add(this.SpeedE);
            this.SpeedGroup.Location = new System.Drawing.Point(973, 12);
            this.SpeedGroup.Name = "SpeedGroup";
            this.SpeedGroup.Size = new System.Drawing.Size(141, 154);
            this.SpeedGroup.TabIndex = 6;
            this.SpeedGroup.TabStop = false;
            this.SpeedGroup.Text = "Speed";
            // 
            // SpeedH
            // 
            this.SpeedH.AutoSize = true;
            this.SpeedH.Location = new System.Drawing.Point(6, 49);
            this.SpeedH.Name = "SpeedH";
            this.SpeedH.Size = new System.Drawing.Size(56, 19);
            this.SpeedH.TabIndex = 6;
            this.SpeedH.TabStop = true;
            this.SpeedH.Text = "Hard";
            this.SpeedH.UseVisualStyleBackColor = true;
            this.SpeedH.CheckedChanged += new System.EventHandler(this.SpeedH_CheckedChanged);
            // 
            // SpeedEX
            // 
            this.SpeedEX.AutoSize = true;
            this.SpeedEX.Location = new System.Drawing.Point(6, 74);
            this.SpeedEX.Name = "SpeedEX";
            this.SpeedEX.Size = new System.Drawing.Size(70, 19);
            this.SpeedEX.TabIndex = 5;
            this.SpeedEX.TabStop = true;
            this.SpeedEX.Text = "???????";
            this.SpeedEX.UseVisualStyleBackColor = true;
            this.SpeedEX.CheckedChanged += new System.EventHandler(this.SpeedEX_CheckedChanged);
            // 
            // SpeedE
            // 
            this.SpeedE.AutoSize = true;
            this.SpeedE.Location = new System.Drawing.Point(6, 24);
            this.SpeedE.Name = "SpeedE";
            this.SpeedE.Size = new System.Drawing.Size(55, 19);
            this.SpeedE.TabIndex = 3;
            this.SpeedE.TabStop = true;
            this.SpeedE.Text = "Easy";
            this.SpeedE.UseVisualStyleBackColor = true;
            this.SpeedE.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.SystemColors.Control;
            this.StartBtn.Location = new System.Drawing.Point(826, 446);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(100, 64);
            this.StartBtn.TabIndex = 6;
            this.StartBtn.Text = "(G)ameStart";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ResetBtn.Location = new System.Drawing.Point(949, 446);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(100, 64);
            this.ResetBtn.TabIndex = 7;
            this.ResetBtn.Text = "(R)eset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // PauseBtn
            // 
            this.PauseBtn.BackColor = System.Drawing.SystemColors.Control;
            this.PauseBtn.Location = new System.Drawing.Point(1069, 446);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(100, 64);
            this.PauseBtn.TabIndex = 8;
            this.PauseBtn.Text = "(P)ause";
            this.PauseBtn.UseVisualStyleBackColor = false;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ScoreLabel.Location = new System.Drawing.Point(827, 271);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(100, 29);
            this.ScoreLabel.TabIndex = 9;
            this.ScoreLabel.Text = "Score: ";
            // 
            // HighScoreLabel
            // 
            this.HighScoreLabel.AutoSize = true;
            this.HighScoreLabel.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScoreLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.HighScoreLabel.Location = new System.Drawing.Point(827, 195);
            this.HighScoreLabel.Name = "HighScoreLabel";
            this.HighScoreLabel.Size = new System.Drawing.Size(163, 29);
            this.HighScoreLabel.TabIndex = 10;
            this.HighScoreLabel.Text = "High Score: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 522);
            this.Controls.Add(this.HighScoreLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.PauseBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.SpeedGroup);
            this.Controls.Add(this.DiffGroup);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.DiffGroup.ResumeLayout(false);
            this.DiffGroup.PerformLayout();
            this.SpeedGroup.ResumeLayout(false);
            this.SpeedGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton DiffH;
        private System.Windows.Forms.GroupBox DiffGroup;
        private System.Windows.Forms.RadioButton DiffEX;
        private System.Windows.Forms.RadioButton DiffHow;
        private System.Windows.Forms.RadioButton DiffE;
        private System.Windows.Forms.RadioButton DiffN;
        private System.Windows.Forms.GroupBox SpeedGroup;
        private System.Windows.Forms.RadioButton SpeedEX;
        private System.Windows.Forms.RadioButton SpeedE;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.RadioButton SpeedH;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label HighScoreLabel;
    }
}

