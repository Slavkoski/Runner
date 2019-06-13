using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Runner
{
    public partial class Form1 : Form
    {
        // goleminata na formata realno e H=495 i W=759, provereno so MessageBox.Show(Width + " " + Height);
        int currHeight = 495;
        int currWidth = 759;
        //dali sme vo igra , kje ni treba za tajmerite dali chovekot da skoka i slichno
        bool inGame;
        bool inJump;
        static int x=0;
        static int y = 50;
        Player player;

        public Form1()
        {
            InitializeComponent();
            player = new Player();
            player.center = pictureBox1.Location;
            timerJump.Stop();
            inGame = false;
            inJump = false;
        }

        // Menuvanje na kopcinjata za vidlivost
        public void buttonVisible(bool visible)
        {
            btnPlay.Visible = visible;
            btnNewGame.Visible = visible;
            btnOpen.Visible = visible;
            btnSave.Visible = visible;
        }
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            buttonVisible(false);
            timer1.Enabled = true;
            inGame = true;
        }

        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (!inJump && (e.KeyCode == Keys.Up || Keyboard.IsKeyDown(Key.Up) && Keyboard.IsKeyDown(Key.Right)))
            {
                timerJump.Start();
            }

            if (e.KeyData == Keys.P || e.KeyData == Keys.Escape)
            {
                timer1.Enabled = false;
                buttonVisible(true);
            }
            else if (e.KeyCode == Keys.Right)
            {
                player.moveRight(Width);
            }else if (e.KeyCode == Keys.Left)
            {
                player.moveLeft();
            } 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate(true);
            pictureBox1.Location = player.center;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Width = currWidth;
            this.Height = currHeight;
        }

        private void timerJump_Tick(object sender, EventArgs e)
        {
            player.Jump();
            if (!player.isInJump())
            {
                timerJump.Stop();
            }
        }
    }
}
