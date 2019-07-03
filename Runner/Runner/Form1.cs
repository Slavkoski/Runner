using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Runner
{
    public partial class Form1 : Form
    {
        
        private bool jump;
        private bool isJumping;
        private bool right;
        private bool gameOver;
        private bool fall;
        private bool decrementFloor;
        private bool pause;
        private int flying;
        private int Score;
        private int HighScore;
        private static int floorWidth;

        //Serialization
        private string SerializationPath;
        private string FolderPath;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
           
            jump = false;
            isJumping = false;
            right = false;
            gameOver = false;
            fall = false;
            pause = false;
            flying = 0;
            Score = 0;
            HighScore = 0;
            pictureBoxCoin2.Image = pictureBoxCoin1.Image;
            pictureBoxCoin2.Width = pictureBoxCoin1.Width;
            pictureBoxCoin2.Height = pictureBoxCoin1.Height;

            floorWidth = floor.Width;

            // Serialization
            FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Runner Game");
            Console.WriteLine(FolderPath);
            SerializationPath = Path.Combine(FolderPath, "highscore.bin");
            Console.WriteLine(SerializationPath);


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
            pictureBox1.Visible = true;
            if (!pause)
            {
                Score = 0;
                decrementFloor = false;

                pictureBoxCactus1.Visible = false;
                pictureBoxCactus2.Visible = false;
            }

            pause = false;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void PlayAgain()
        {
            floor.Location = new Point(0, MaximumSize.Height - 70);
            floor2.Location = new Point(floor.Width + 200, MaximumSize.Height - 70);
            pictureBox1.Location = new Point(40, 340-50);
            pictureBoxCactus1.Location = new  Point(floor.Width/2,MaximumSize.Height - 103);
            pictureBoxCactus2.Location = new  Point(floor2.Location.X + floor.Width/2,MaximumSize.Height - 103);
            pictureBoxCoin1.Location = new Point(floor.Location.X + floor.Width + 100, MaximumSize.Height-230);
            pictureBoxCoin2.Location = new Point(floor2.Location.X + floor2.Width + 100, MaximumSize.Height-230);

            floor.Width = floorWidth;
            floor2.Width = floorWidth;

            lblHighScore.Text = HighScore.ToString();

            gameOver = false;
            flying = 0;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.P || e.KeyData == Keys.Escape)
            {
                pause = true;
                timer1.Enabled = false;
                buttonVisible(true);
            }
            else if (e.KeyCode == Keys.Right)
            {
                right = true;
                
            }
            if ((e.KeyCode == Keys.Space || e.KeyCode == Keys.Up) && jump == false && isJumping == false)
            {
                jump = true;
                isJumping = true;
            }
            

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate(true);
            //pictureBox1.Location = player.center;
            // Ako pagja nadole da nemoze da se kace tuku da padne
            if (gameOver)
            {
                endGame();
            }
            if (!fall)
            {
                // Ako imame straknato space neka leta
                if (jump && flying < 15)
                {
                    moveUp();
                }

                // Ako imame dostignato sakanata visina vrati go nazad
                if (!jump && flying > 0)
                {
                    moveDown();
                }

                // Ako imame pritisnato desno da go dvizime desno
                if (right)
                {
                    moveRight();
                }
                // Ako a fanime prvata para

                if (pictureBoxCoin1.Visible && isOverlap(pictureBox1.Location,pictureBox1.Width,pictureBox1.Height,pictureBoxCoin1.Location,pictureBoxCoin1.Width,pictureBoxCoin1.Height))
                {
                    Score++;
                    pictureBoxCoin1.Visible = false;
                }
                // Ako a fanime vtorata para
                if (pictureBoxCoin2.Visible && isOverlap(pictureBox1.Location, pictureBox1.Width, pictureBox1.Height, pictureBoxCoin2.Location, pictureBoxCoin2.Width, pictureBoxCoin2.Height))
                {
                    Score++;
                    pictureBoxCoin2.Visible = false;
                }



                //Ako Cepne cactus game over
                if (pictureBoxCactus1.Visible && pictureBoxCoin1.Visible
                                              && 
                                              isTouching(pictureBox1.Location, pictureBoxCactus1.Location)
                    )
                {
                    gameOver = true;
                }
                //Ako Cepne cactus game over
                if (pictureBoxCactus2.Visible && pictureBoxCoin1.Visible && 
                        isTouching(pictureBox1.Location, pictureBoxCactus2.Location)
                    )
                {
                    gameOver = true;
                }




                // Ako isceznalo prviot block dodadi go na location width + dupkata so a sakame
                if (floor.Location.X < -floor.Width)
                {
                    floor.Location = new Point(floor2.Location.X + 200 + floor2.Width, floor2.Location.Y);
                    pictureBoxCoin2.Location = new Point(floor.Location.X - 100, pictureBoxCoin2.Location.Y);
                    pictureBoxCactus1.Location = new Point(floor.Location.X + (floor.Width / 2), pictureBoxCactus1.Location.Y);
                    pictureBoxCoin2.Visible = true;
                }

                if (floor2.Location.X < -floor2.Width)
                {
                    floor2.Location = new Point(floor.Location.X + 200 + floor.Width, floor.Location.Y);
                    pictureBoxCoin1.Location = new Point(floor2.Location.X - 100, pictureBoxCoin1.Location.Y);
                    pictureBoxCactus2.Location = new Point(floor2.Location.X + (floor2.Width / 2), pictureBoxCactus2.Location.Y);
                    pictureBoxCoin1.Visible = true;
                }

                if (!isJumping &&
                    !isOverlap(pictureBox1.Location, pictureBox1.Width, pictureBox1.Height, floor.Location, floor.Width, floor.Height)&&
                    !isOverlap(pictureBox1.Location, pictureBox1.Width, pictureBox1.Height, floor2.Location, floor2.Width, floor2.Height) ||
                    floor.Location.X + floor.Width < pictureBox1.Location.X + 30 && !isJumping || floor2.Location.X + floor2.Width < pictureBox1.Location.X + 30 && !isJumping)
                {
                    fall = true;
                }

                lblScore.Text = Score.ToString();
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
                    Score = 0;
                    buttonVisible(true);
                    fall = false;
                    gameOver = true;
                }
            }
        }

        public bool isTouching(Point stick, Point cactus)

        {
            return stick.X + pictureBox1.Width >= cactus.X && stick.X < cactus.X && stick.Y + pictureBox1.Height >= cactus.Y;
        }
        //FUNKCI

        public void moveRight()
        {
            floor.Location = new Point(floor.Location.X - 7, floor.Location.Y);
            floor2.Location = new Point(floor2.Location.X - 7, floor2.Location.Y);
            pictureBoxCoin1.Location = new Point(pictureBoxCoin1.Location.X - 7, pictureBoxCoin1.Location.Y);
            pictureBoxCoin2.Location = new Point(pictureBoxCoin2.Location.X - 7, pictureBoxCoin2.Location.Y);
            pictureBoxCactus2.Location = new Point(pictureBoxCactus2.Location.X - 7, pictureBoxCactus2.Location.Y);
            pictureBoxCactus1.Location = new Point(pictureBoxCactus1.Location.X - 7, pictureBoxCactus1.Location.Y);
            if (Score == 6)
            {
                pictureBoxCactus1.Visible = true;
                pictureBoxCactus2.Visible = true;
            }

            //namaluvanje na floor

            if (Score % 9 == 0 && Score != 0 && !decrementFloor)
            {
                decrementFloor = true;
            }

            if (decrementFloor && Score % 9 != 0)
            {
                decrementFloor = false;
                floor.Width -= 3;
                floor2.Width -= 3;
            }
        }

        public void moveUp()
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 5);
            flying++;
            if (flying == 15)
            {
                jump = false;
            }
        }

        public void moveDown()
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 5);
            flying--;
            if (flying == 0)
            {
                isJumping = false;
            }
        }

        public void endGame()
        {
            jump = false;
            isJumping = false;
            timer1.Enabled = false;
            pictureBoxCactus1.Visible = false;
            pictureBoxCactus2.Visible = false;
            btnPlay.Text = "Play Again";
            if (Score > HighScore)
            {
                HighScore = Score;
                lblCenterHighScore.Text = "New High Score!";
            }
            lblCenterScore.Text = HighScore.ToString();
            buttonVisible(true);
            fall = false;

            pictureBox1.Visible = false;
            PlayAgain();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public bool isOverlap(Point rectangle1, int widthRec1, int heightRec1, Point rectangle2, int widthRec2, int heightRec2)
        {
            if (((rectangle1.X >= rectangle2.X && rectangle1.X <= rectangle2.X + widthRec2) ||
                 (rectangle1.X + widthRec1 >= rectangle2.X && rectangle1.X + widthRec1 <= rectangle2.X + widthRec2)) &&
                ((rectangle1.Y >= rectangle2.Y && rectangle1.Y <= rectangle2.Y + heightRec2) ||
                 (rectangle1.Y + heightRec1 >= rectangle2.Y && rectangle1.Y + heightRec1 <= rectangle2.Y + heightRec2)))
                return true;
            return false;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Right)
            {
                right = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(SerializationPath))
            {
                try
                {
                    using (var stream = new FileStream(SerializationPath, FileMode.Open, FileAccess.Read))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        HighScore = (int) formatter.Deserialize(stream);
                       
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error file cannot be open");
                    Console.WriteLine(ex.ToString());
                }
            }
            else
            {
                HighScore = 0;
                Console.WriteLine("File not exist!");
            }

            lblHighScore.Text = HighScore.ToString();
            lblCenterScore.Text = HighScore.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit the application", "Quit the application",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!Directory.Exists(FolderPath))
                {
                    try
                    {
                        Directory.CreateDirectory(FolderPath);
                        Console.WriteLine("Folder Succesfully created");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("ERROR! Folder is not created");
                        return;
                    }
                }

                //Starting Serialization
                try
                {
                    var myFile = new FileInfo(SerializationPath);
                    if (myFile.Exists)
                    {
                        myFile.Attributes &= ~FileAttributes.Hidden;
                    }

                    using (var stream = new FileStream(SerializationPath, FileMode.Create, FileAccess.Write))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(stream, HighScore);
                    }

                    File.SetAttributes(SerializationPath,
                        File.GetAttributes(SerializationPath) | FileAttributes.Hidden);


                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR! Cannot Save file");
                }
            }
            else
            {
                e.Cancel = true;
            }

        }
    }
}
