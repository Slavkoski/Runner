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
        public Form1()
        {
            InitializeComponent();
            player = new Player();
            player.center = pictureBox1.Location;
            player.width = this.Width-70;
            player.height = this.Height;
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
                player.moveRight();
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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
