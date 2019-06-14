namespace Runner
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.floor = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.floor2 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCenterHighScore = new System.Windows.Forms.Label();
            this.lblCenterScore = new System.Windows.Forms.Label();
            this.pictureBoxCoin1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCactus1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCactus2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCactus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCactus2)).BeginInit();
            this.SuspendLayout();
            // 
            // floor
            // 
            this.floor.BackgroundImage = global::Runner.Properties.Resources.platform;
            this.floor.Image = global::Runner.Properties.Resources.platform;
            this.floor.Location = new System.Drawing.Point(0, 465);
            this.floor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(380, 50);
            this.floor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.floor.TabIndex = 0;
            this.floor.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.SeaShell;
            this.btnPlay.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnPlay.Location = new System.Drawing.Point(377, 200);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "High Score: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(743, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Press P or Esc for pause";
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Runner.Properties.Resources.transparent_runner;
            this.pictureBox1.Location = new System.Drawing.Point(12, 345);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // floor2
            // 
            this.floor2.BackgroundImage = global::Runner.Properties.Resources.platform;
            this.floor2.Image = global::Runner.Properties.Resources.platform;
            this.floor2.Location = new System.Drawing.Point(602, 465);
            this.floor2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.floor2.Name = "floor2";
            this.floor2.Size = new System.Drawing.Size(380, 50);
            this.floor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.floor2.TabIndex = 1;
            this.floor2.TabStop = false;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Score: ";
            // 
            // lblCenterHighScore
            // 
            this.lblCenterHighScore.AutoSize = true;
            this.lblCenterHighScore.BackColor = System.Drawing.Color.Transparent;
            this.lblCenterHighScore.Font = new System.Drawing.Font("Courier New", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCenterHighScore.Location = new System.Drawing.Point(359, 71);
            this.lblCenterHighScore.Name = "lblCenterHighScore";
            this.lblCenterHighScore.Size = new System.Drawing.Size(270, 45);
            this.lblCenterHighScore.TabIndex = 12;
            this.lblCenterHighScore.Text = "High Score";
            // 
            // lblCenterScore
            // 
            this.lblCenterScore.AutoSize = true;
            this.lblCenterScore.BackColor = System.Drawing.Color.Transparent;
            this.lblCenterScore.Font = new System.Drawing.Font("Courier New", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCenterScore.Location = new System.Drawing.Point(471, 134);
            this.lblCenterScore.Name = "lblCenterScore";
            this.lblCenterScore.Size = new System.Drawing.Size(45, 45);
            this.lblCenterScore.TabIndex = 13;
            this.lblCenterScore.Text = "0";
            // 
            // pictureBoxCoin1
            // 
            this.pictureBoxCoin1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin1.Image")));
            this.pictureBoxCoin1.Location = new System.Drawing.Point(459, 290);
            this.pictureBoxCoin1.Name = "pictureBoxCoin1";
            this.pictureBoxCoin1.Size = new System.Drawing.Size(57, 49);
            this.pictureBoxCoin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin1.TabIndex = 14;
            this.pictureBoxCoin1.TabStop = false;
            // 
            // pictureBoxCoin2
            // 
            this.pictureBoxCoin2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin2.Image")));
            this.pictureBoxCoin2.Location = new System.Drawing.Point(1100, 290);
            this.pictureBoxCoin2.Name = "pictureBoxCoin2";
            this.pictureBoxCoin2.Size = new System.Drawing.Size(57, 49);
            this.pictureBoxCoin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin2.TabIndex = 15;
            this.pictureBoxCoin2.TabStop = false;
            // 
            // pictureBoxCactus1
            // 
            this.pictureBoxCactus1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCactus1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCactus1.Image")));
            this.pictureBoxCactus1.Location = new System.Drawing.Point(112, 427);
            this.pictureBoxCactus1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCactus1.Name = "pictureBoxCactus1";
            this.pictureBoxCactus1.Size = new System.Drawing.Size(26, 38);
            this.pictureBoxCactus1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCactus1.TabIndex = 17;
            this.pictureBoxCactus1.TabStop = false;
            this.pictureBoxCactus1.Visible = false;
            // 
            // pictureBoxCactus2
            // 
            this.pictureBoxCactus2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCactus2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCactus2.Image")));
            this.pictureBoxCactus2.Location = new System.Drawing.Point(805, 427);
            this.pictureBoxCactus2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCactus2.Name = "pictureBoxCactus2";
            this.pictureBoxCactus2.Size = new System.Drawing.Size(26, 38);
            this.pictureBoxCactus2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCactus2.TabIndex = 18;
            this.pictureBoxCactus2.TabStop = false;
            this.pictureBoxCactus2.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPlay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Runner.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 508);
            this.Controls.Add(this.pictureBoxCactus2);
            this.Controls.Add(this.pictureBoxCactus1);
            this.Controls.Add(this.pictureBoxCoin2);
            this.Controls.Add(this.pictureBoxCoin1);
            this.Controls.Add(this.lblCenterScore);
            this.Controls.Add(this.lblCenterHighScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.floor2);
            this.Controls.Add(this.floor);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 555);
            this.MinimumSize = new System.Drawing.Size(1000, 555);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Runner";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCactus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCactus2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox floor2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCenterHighScore;
        private System.Windows.Forms.Label lblCenterScore;
        private System.Windows.Forms.PictureBox pictureBoxCoin1;
        private System.Windows.Forms.PictureBox pictureBoxCoin2;
        private System.Windows.Forms.PictureBox pictureBoxCactus1;
        private System.Windows.Forms.PictureBox pictureBoxCactus2;
    }
}

