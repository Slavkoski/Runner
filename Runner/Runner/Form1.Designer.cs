namespace Runner
{
    partial class formRunner
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRunner));
            this.pbFloor1 = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblForHighScore = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbFloor2 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblForScore = new System.Windows.Forms.Label();
            this.lbForlCenterHighScore = new System.Windows.Forms.Label();
            this.lblCenterHighScore = new System.Windows.Forms.Label();
            this.pbCoin1 = new System.Windows.Forms.PictureBox();
            this.pbCoin2 = new System.Windows.Forms.PictureBox();
            this.pbCactus1 = new System.Windows.Forms.PictureBox();
            this.pbCactus2 = new System.Windows.Forms.PictureBox();
            this.lblKontroli = new System.Windows.Forms.Label();
            this.lblForCurrentScore = new System.Windows.Forms.Label();
            this.lblCurrentScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFloor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFloor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCactus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCactus2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFloor1
            // 
            this.pbFloor1.BackgroundImage = global::Runner.Properties.Resources.platform;
            this.pbFloor1.Image = global::Runner.Properties.Resources.platform;
            this.pbFloor1.Location = new System.Drawing.Point(0, 465);
            this.pbFloor1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbFloor1.Name = "pbFloor1";
            this.pbFloor1.Size = new System.Drawing.Size(380, 50);
            this.pbFloor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFloor1.TabIndex = 0;
            this.pbFloor1.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.SeaShell;
            this.btnPlay.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnPlay.Location = new System.Drawing.Point(375, 211);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(5);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(228, 65);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblForHighScore
            // 
            this.lblForHighScore.AutoSize = true;
            this.lblForHighScore.BackColor = System.Drawing.Color.Transparent;
            this.lblForHighScore.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForHighScore.Location = new System.Drawing.Point(12, 9);
            this.lblForHighScore.Name = "lblForHighScore";
            this.lblForHighScore.Size = new System.Drawing.Size(104, 17);
            this.lblForHighScore.TabIndex = 3;
            this.lblForHighScore.Text = "High Score: ";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.BackColor = System.Drawing.Color.Transparent;
            this.lblHighScore.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.Location = new System.Drawing.Point(109, 9);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(16, 17);
            this.lblHighScore.TabIndex = 5;
            this.lblHighScore.Text = "0";
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer.Image = global::Runner.Properties.Resources.transparent_runner;
            this.pbPlayer.Location = new System.Drawing.Point(40, 345);
            this.pbPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(88, 121);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 9;
            this.pbPlayer.TabStop = false;
            this.pbPlayer.Visible = false;
            // 
            // pbFloor2
            // 
            this.pbFloor2.BackgroundImage = global::Runner.Properties.Resources.platform;
            this.pbFloor2.Image = global::Runner.Properties.Resources.platform;
            this.pbFloor2.Location = new System.Drawing.Point(603, 465);
            this.pbFloor2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbFloor2.Name = "pbFloor2";
            this.pbFloor2.Size = new System.Drawing.Size(380, 50);
            this.pbFloor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFloor2.TabIndex = 1;
            this.pbFloor2.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(72, 38);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(16, 17);
            this.lblScore.TabIndex = 11;
            this.lblScore.Text = "0";
            // 
            // lblForScore
            // 
            this.lblForScore.AutoSize = true;
            this.lblForScore.BackColor = System.Drawing.Color.Transparent;
            this.lblForScore.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForScore.Location = new System.Drawing.Point(12, 38);
            this.lblForScore.Name = "lblForScore";
            this.lblForScore.Size = new System.Drawing.Size(64, 17);
            this.lblForScore.TabIndex = 10;
            this.lblForScore.Text = "Score: ";
            // 
            // lbForlCenterHighScore
            // 
            this.lbForlCenterHighScore.AutoSize = true;
            this.lbForlCenterHighScore.BackColor = System.Drawing.Color.Transparent;
            this.lbForlCenterHighScore.Font = new System.Drawing.Font("Courier New", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForlCenterHighScore.Location = new System.Drawing.Point(308, 38);
            this.lbForlCenterHighScore.Name = "lbForlCenterHighScore";
            this.lbForlCenterHighScore.Size = new System.Drawing.Size(295, 45);
            this.lbForlCenterHighScore.TabIndex = 12;
            this.lbForlCenterHighScore.Text = "High Score:";
            // 
            // lblCenterHighScore
            // 
            this.lblCenterHighScore.AutoSize = true;
            this.lblCenterHighScore.BackColor = System.Drawing.Color.Transparent;
            this.lblCenterHighScore.Font = new System.Drawing.Font("Courier New", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCenterHighScore.Location = new System.Drawing.Point(625, 38);
            this.lblCenterHighScore.Name = "lblCenterHighScore";
            this.lblCenterHighScore.Size = new System.Drawing.Size(45, 45);
            this.lblCenterHighScore.TabIndex = 13;
            this.lblCenterHighScore.Text = "0";
            // 
            // pbCoin1
            // 
            this.pbCoin1.BackColor = System.Drawing.Color.Transparent;
            this.pbCoin1.Image = ((System.Drawing.Image)(resources.GetObject("pbCoin1.Image")));
            this.pbCoin1.Location = new System.Drawing.Point(475, 270);
            this.pbCoin1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCoin1.Name = "pbCoin1";
            this.pbCoin1.Size = new System.Drawing.Size(43, 39);
            this.pbCoin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCoin1.TabIndex = 14;
            this.pbCoin1.TabStop = false;
            // 
            // pbCoin2
            // 
            this.pbCoin2.BackColor = System.Drawing.Color.Transparent;
            this.pbCoin2.Image = ((System.Drawing.Image)(resources.GetObject("pbCoin2.Image")));
            this.pbCoin2.Location = new System.Drawing.Point(1120, 270);
            this.pbCoin2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCoin2.Name = "pbCoin2";
            this.pbCoin2.Size = new System.Drawing.Size(43, 39);
            this.pbCoin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCoin2.TabIndex = 15;
            this.pbCoin2.TabStop = false;
            // 
            // pbCactus1
            // 
            this.pbCactus1.BackColor = System.Drawing.Color.Transparent;
            this.pbCactus1.Image = ((System.Drawing.Image)(resources.GetObject("pbCactus1.Image")));
            this.pbCactus1.Location = new System.Drawing.Point(112, 427);
            this.pbCactus1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCactus1.Name = "pbCactus1";
            this.pbCactus1.Size = new System.Drawing.Size(27, 38);
            this.pbCactus1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCactus1.TabIndex = 17;
            this.pbCactus1.TabStop = false;
            this.pbCactus1.Visible = false;
            // 
            // pbCactus2
            // 
            this.pbCactus2.BackColor = System.Drawing.Color.Transparent;
            this.pbCactus2.Image = ((System.Drawing.Image)(resources.GetObject("pbCactus2.Image")));
            this.pbCactus2.Location = new System.Drawing.Point(805, 427);
            this.pbCactus2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCactus2.Name = "pbCactus2";
            this.pbCactus2.Size = new System.Drawing.Size(27, 38);
            this.pbCactus2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCactus2.TabIndex = 18;
            this.pbCactus2.TabStop = false;
            this.pbCactus2.Visible = false;
            // 
            // lblKontroli
            // 
            this.lblKontroli.AutoSize = true;
            this.lblKontroli.BackColor = System.Drawing.Color.Transparent;
            this.lblKontroli.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKontroli.Location = new System.Drawing.Point(350, 281);
            this.lblKontroli.Name = "lblKontroli";
            this.lblKontroli.Size = new System.Drawing.Size(253, 120);
            this.lblKontroli.TabIndex = 19;
            this.lblKontroli.Text = "How to play?\r\nPress Esc or P for Pause\r\nPress Space or Up for jump\r\nPress Right t" +
    "o move\r\n";
            this.lblKontroli.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblForCurrentScore
            // 
            this.lblForCurrentScore.AutoSize = true;
            this.lblForCurrentScore.BackColor = System.Drawing.Color.Transparent;
            this.lblForCurrentScore.Font = new System.Drawing.Font("Courier New", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForCurrentScore.Location = new System.Drawing.Point(207, 118);
            this.lblForCurrentScore.Name = "lblForCurrentScore";
            this.lblForCurrentScore.Size = new System.Drawing.Size(495, 45);
            this.lblForCurrentScore.TabIndex = 22;
            this.lblForCurrentScore.Text = "Your current score:";
            // 
            // lblCurrentScore
            // 
            this.lblCurrentScore.AutoSize = true;
            this.lblCurrentScore.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentScore.Font = new System.Drawing.Font("Courier New", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentScore.Location = new System.Drawing.Point(727, 118);
            this.lblCurrentScore.Name = "lblCurrentScore";
            this.lblCurrentScore.Size = new System.Drawing.Size(45, 45);
            this.lblCurrentScore.TabIndex = 23;
            this.lblCurrentScore.Text = "0";
            // 
            // formRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Runner.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(981, 506);
            this.Controls.Add(this.lblCurrentScore);
            this.Controls.Add(this.lblForCurrentScore);
            this.Controls.Add(this.lblKontroli);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pbCoin1);
            this.Controls.Add(this.pbCactus2);
            this.Controls.Add(this.pbCactus1);
            this.Controls.Add(this.pbCoin2);
            this.Controls.Add(this.lblCenterHighScore);
            this.Controls.Add(this.lbForlCenterHighScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblForScore);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblForHighScore);
            this.Controls.Add(this.pbFloor2);
            this.Controls.Add(this.pbFloor1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(999, 553);
            this.MinimumSize = new System.Drawing.Size(999, 553);
            this.Name = "formRunner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Runner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbFloor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFloor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCactus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCactus2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFloor1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblForHighScore;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbFloor2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblForScore;
        private System.Windows.Forms.Label lbForlCenterHighScore;
        private System.Windows.Forms.Label lblCenterHighScore;
        private System.Windows.Forms.PictureBox pbCoin1;
        private System.Windows.Forms.PictureBox pbCoin2;
        private System.Windows.Forms.PictureBox pbCactus1;
        private System.Windows.Forms.PictureBox pbCactus2;
        private System.Windows.Forms.Label lblKontroli;
        private System.Windows.Forms.Label lblForCurrentScore;
        private System.Windows.Forms.Label lblCurrentScore;
    }
}

