using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Runner
{
    public partial class Form1 : Form
    {
        static int x=0;
        static int y = 50;
        Player player;
        private bool jump;
        private bool right;
        private bool fall;
        private int flying;
        private int Score;
        private int HighScore;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            player = new Player();
            player.center = pictureBox1.Location;
            player.width = this.Width-70;
            player.height = this.Height;
            jump = false;
            right = false;
            fall = false;
            flying = 0;
            Score = 0;
            HighScore = 0;
        }

        // Menuvanje na kopcinjata za vidlivost
        public void buttonVisible(bool visible)
        {
            btnPlay.Visible = visible;
            lblCenterHighScore.Visible = visible;
            lblCenterScore.Visible = visible;
        }
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            buttonVisible(false);
            timer1.Enabled = true;
            lblCenterHighScore.Text = "High Score";
            Score = 0;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.P || e.KeyData == Keys.Escape)
            {
                timer1.Enabled = false;
                buttonVisible(true);
            }
            else if (e.KeyCode == Keys.Right)
            {
                //    player.moveRight();
                right = true;
                
            }
            if (e.KeyCode == Keys.Space && jump == false)
            {
                // player.moveLeft();
                jump = true;
            }
            

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate(true);
            //pictureBox1.Location = player.center;
            // Ako pagja nadole da nemoze da se kace tuku da padne
            if (!fall)
            {
                // Ako imame straknato space neka leta
                if (jump && flying < 15)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 5);
                    flying++;
                    if (flying == 15)
                    {
                        jump = false;
                    }
                }

                // Ako imame dostignato sakanata visina vrati go nazad
                if (!jump && flying > 0)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 5);
                    flying--;
                }

                // Ako imame pritisnato desno da go dvizime desno
                if (right)
                {
                    floor.Location = new Point(floor.Location.X - 5, floor.Location.Y);
                    floor2.Location = new Point(floor2.Location.X - 5, floor2.Location.Y);
                    pictureBoxCoin1.Location = new Point(pictureBoxCoin1.Location.X -5 , pictureBoxCoin1.Location.Y);
                    pictureBoxCoin2.Location = new Point(pictureBoxCoin2.Location.X -5 , pictureBoxCoin2.Location.Y);
                }
                // Ako a fanime prvata para
                if (pictureBox1.Location.X == pictureBoxCoin1.Location.X)
                {
                    Score++;
                    pictureBoxCoin1.Visible = false;
                }
                // Ako a fanime prvata para
                if (pictureBox1.Location.X == pictureBoxCoin2.Location.X)
                {
                    Score++;
                    pictureBoxCoin2.Visible = false;
                }
                // Ako isceznalo prviot block dodadi go na location width + dupkata so a sakame
                if (floor.Location.X < -floor.Width)
                {
                    floor.Location = new Point(floor2.Location.X + 200 + floor2.Width, floor2.Location.Y);
                    pictureBoxCoin2.Location = new Point(floor.Location.X, pictureBoxCoin2.Location.Y);
                    pictureBoxCoin2.Visible = true;
                }

                if (floor2.Location.X < -floor2.Width)
                {
                    floor2.Location = new Point(floor.Location.X + 200 + floor.Width, floor.Location.Y);
                    pictureBoxCoin1.Location = new Point(floor2.Location.X, pictureBoxCoin1.Location.Y);
                    pictureBoxCoin1.Visible = true;
                }

                if (!jump && (pictureBox1.Location.X > floor.Location.X + floor.Width &&
                              pictureBox1.Location.X < floor2.Location.X) ||
                            (pictureBox1.Location.X > floor2.Location.X + floor2.Width &&
                             pictureBox1.Location.X < floor.Location.X))
                {
                    fall = true;
                }
            }
            else
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 8);
                floor.Location = new Point(floor.Location.X - 5, floor.Location.Y);
                floor2.Location = new Point(floor2.Location.X - 5, floor2.Location.Y);
                //Game Over
                if (pictureBox1.Location.Y + 120 >= 555)
                {
                    timer1.Enabled = false;
                    btnPlay.Text = "Play Again";
                    if (Score > HighScore)
                    {
                        HighScore = Score;
                        lblCenterHighScore.Text = "New High Score!";
                    }
                    lblCenterScore.Text = HighScore.ToString();
                    buttonVisible(true);
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Right)
            {
                right = false;
            }
        }
    }
}
