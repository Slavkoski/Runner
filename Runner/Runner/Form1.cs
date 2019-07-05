using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Runner
{
    public partial class formRunner : Form
    {
        public static int MOVE_DISTANCE = 9;
        private bool jump;
        private bool isJumping;
        private bool right;
        private bool gameOver;
        private bool fall;
        private bool decrementFloor;
        private bool addVelocity;
        private bool pause;
        private bool isSpace;
        private bool handled;
        private int flying;
        private int Score;
        private int HighScore;
        private static int floorWidth;
        public bool cactusShow;
        public bool day;
        public bool midnight;
        public int stickmanWaiting;

        //sliki za pozadini za pause i play
        Image BackgroundPHOTO;
        Image BackgroundPausePHOTO;
        Image PlayerPHOTO;
        Image PlayerStandsPHOTO;
        Image BackgroundNightPHOTO;
        Image BackgroundMidNightPHOTO;
        Image SoundOn;
        Image SoundOff;
        SoundPlayer soundPlayer;

        //Serialization
        private string SerializationPath;
        private string FolderPath;

        public formRunner()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            jump = false;
            isJumping = false;
            right = false;
            gameOver = false;
            fall = false;
            pause = true;
            addVelocity = false;
            handled = false;
            isSpace = false;
            flying = 0;
            Score = 0;
            HighScore = 0;
            cactusShow = false;
            pbCoin2.Image = pbCoin1.Image;
            pbCoin2.Width = pbCoin1.Width;
            pbCoin2.Height = pbCoin1.Height;
            pbCoin1.Visible = false;
            btnPlay.Text = "Play new game";
            lblKontroli.Visible = true;
            lblScore.Visible = false;
            lblHighScore.Visible = false;
            lblForScore.Visible = false;
            lblForHighScore.Visible = false;
            lblForCurrentScore.Visible = false;
            lblCurrentScore.Visible = false;
            //Background photo
            BackgroundNightPHOTO = global::Runner.Properties.Resources.background_night;
            BackgroundMidNightPHOTO= global::Runner.Properties.Resources.background_midnight;
            BackgroundPausePHOTO = global::Runner.Properties.Resources.background_pause;
            BackgroundPHOTO = global::Runner.Properties.Resources.background;
            this.BackgroundImage = BackgroundPausePHOTO;

            floorWidth = pbFloor1.Width;

            day = true;
            midnight = false;

            // Serialization
            FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Runner Game");
            Console.WriteLine(FolderPath);
            SerializationPath = Path.Combine(FolderPath, "highscore.bin");
            Console.WriteLine(SerializationPath);


            //MUSIC
            soundPlayer = new SoundPlayer(Properties.Resources.Jamiroquai___Cloud_9__Purple_Disco_Machine_Remix_);
            soundPlayer.PlayLooping();
            SoundOn = global::Runner.Properties.Resources.sound;
            SoundOff = global::Runner.Properties.Resources.Mute;
            pbSound.Image = SoundOn;


            //Player
            PlayerPHOTO = global::Runner.Properties.Resources.transparent_runner;
            PlayerStandsPHOTO = global::Runner.Properties.Resources.transparent_stickman;
            stickmanWaiting = 0;

        }

        // Menuvanje na kopcinjata za vidlivost 
        public void buttonVisible(bool visible)
        {
            btnPlay.Visible = visible;
            lbForlCenterHighScore.Visible = visible;
           // lblCenterHighScore.Visible = visible;

            pbCoin1.Visible = !visible;
            pbCoin2.Visible = !visible;
            lblKontroli.Visible = visible;
            lblScore.Visible = !visible;
            lblHighScore.Visible = !visible;
            lblForHighScore.Visible = !visible;
            lblForScore.Visible = !visible;
            lblCurrentScore.Visible = visible;
            lblForCurrentScore.Visible = visible;
            //dokolku skorot e posle 6 koga kje se pauzira da se sokrijat i kaktusite, prethodno se sokrieni
            if (cactusShow)
            {
                pbCactus1.Visible = !visible;
                pbCactus2.Visible = !visible;
            }

            // dokolku e pauza se menuvaat pozadinite


            if (visible)
          {
               this.BackgroundImage = BackgroundPausePHOTO;
               btnPlay.Text = "Continue";
          }
            else
            {
                if (midnight)
                {
                    BackgroundImage = BackgroundMidNightPHOTO;
                }
                else if (day)
                    BackgroundImage = BackgroundPHOTO;
                else
                    BackgroundImage = BackgroundNightPHOTO;
            }

        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            
            if (handled)
            {
                handled = false;
            }
            else
            {
                buttonVisible(false);
                timer1.Enabled = true;
                lbForlCenterHighScore.Text = "High Score:";
                pbPlayer.Visible = true;


                //dokolku ne e pauza znachi e pochetok, skorot=0, kaktusite gi nema itn
                if ((!pause && !isSpace) || gameOver)
                {
                    Score = 0;
                    decrementFloor = false;
                    pbCactus1.Visible = false;
                    pbCactus2.Visible = false;
                    cactusShow = false;
                    isSpace = false;
                    BackgroundImage = BackgroundPHOTO;
                }

                pause = false;
                fall = false;
                gameOver = false;

            }
        }

        private void PlayAgain()
        {
            pbFloor1.Location = new Point(0, MaximumSize.Height - 70);
            pbFloor2.Location = new Point(pbFloor1.Width + 200, MaximumSize.Height - 70);
            pbPlayer.Location = new Point(40, 340 - 50);
            pbCactus1.Location = new Point(pbFloor1.Width / 2, MaximumSize.Height - 103);
            pbCactus2.Location = new Point(pbFloor2.Location.X + pbFloor1.Width / 2, MaximumSize.Height - 103);
            pbCoin1.Location = new Point(pbFloor1.Location.X + pbFloor1.Width + 100, MaximumSize.Height - 230);
            pbCoin2.Location = new Point(pbFloor2.Location.X + pbFloor2.Width + 100, MaximumSize.Height - 230);

            pbFloor1.Width = floorWidth;
            pbFloor2.Width = floorWidth;

            pbPlayer.Image = PlayerStandsPHOTO;
           // BackgroundImage = BackgroundPHOTO;

            midnight = false;
            day = true;

            MOVE_DISTANCE = 9;

            lblHighScore.Text = HighScore.ToString();
            handled = true;
            flying = 0;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
          {
            // P ili Esc za pause

            if (e.KeyData == Keys.P || e.KeyData == Keys.Escape && !fall)
            {

                pause = true;
                timer1.Enabled = false;
                buttonVisible(true);
                handled = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (stickmanWaiting != 0 && pbPlayer.Image != PlayerPHOTO)
                {
                    pbPlayer.Image = PlayerPHOTO;
                }

                stickmanWaiting = 0;
                right = true;
            }

            if (e.KeyCode == Keys.Space && (pause || gameOver || fall || isJumping || jump))
            {
                handled = true;
            }
            else if ((e.KeyCode == Keys.Space || e.KeyCode == Keys.Up) && !jump && !isJumping && !handled)
            {
                if (stickmanWaiting != 0 && pbPlayer.Image != PlayerPHOTO)
                {
                    pbPlayer.Image = PlayerPHOTO;
                }

                stickmanWaiting = 0;
                isSpace = true;
                jump = true;
                isJumping = true;
                handled = false;
            }

            if (e.KeyCode == Keys.M)
            {
                changeSound();
            }


            if (e.KeyCode != Keys.Space)
            {
                handled = false;
            }
            //RESET HIGHSCORE
            if ( e.KeyCode == Keys.R && pause && HighScore != 0)
            {

                if (MessageBox.Show("Are you sure you want to reset the highscore", "Reset highscore",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    HighScore = 0;
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

                        
                        lblHighScore.Text = HighScore.ToString();
                        lbForlCenterHighScore.Text = "High Score!" + HighScore.ToString();


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("ERROR! Cannot Save file");
                    }
                }


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate(true);


            //pbPlayer.Location = player.center;
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
                else if(!isJumping)
                {
                    stickmanWaiting++;
                    if (stickmanWaiting == 7)
                    {
                        pbPlayer.Image = PlayerStandsPHOTO;
                    }
                }
                // Ako a fanime prvata para

                if (pbCoin1.Visible && isOverlap(pbPlayer.Location, pbPlayer.Width, pbPlayer.Height, pbCoin1.Location,
                        pbCoin1.Width, pbCoin1.Height))
                {
                    Score++;
                    pbCoin1.Visible = false;
                   
                }

                // Ako a fanime vtorata para
                if (pbCoin2.Visible && isOverlap(pbPlayer.Location, pbPlayer.Width, pbPlayer.Height, pbCoin2.Location,
                        pbCoin2.Width, pbCoin2.Height))
                {
                    Score++;
                    pbCoin2.Visible = false;
                }
                // Change background
                if (Score % 10 == 0 && Score % 15 != 0 && Score != 0 && BackgroundImage != BackgroundMidNightPHOTO)
                {
                    if (BackgroundImage == BackgroundPHOTO)
                    {
                        day = true;
                    }
                    else
                    {
                        day = false;
                    }

                    midnight = true;
                    BackgroundImage = BackgroundMidNightPHOTO;

                }
                if (Score % 15 == 0 && Score != 0)
                {
                    if (day)
                    {
                        BackgroundImage = BackgroundNightPHOTO;
                    }
                    else
                    {
                        BackgroundImage = BackgroundPHOTO;
                    }
                    
                    midnight = false;
                }

              

                //Ako Cepne cactus game over
                if ((pbCactus1.Visible && pbCoin1.Visible
                                       &&
                                       isTouching(pbPlayer.Location, pbCactus1.Location)) ||
                    (pbCactus2.Visible && pbCoin2.Visible &&
                     isTouching(pbPlayer.Location, pbCactus2.Location)))
                {
                    gameOver = true;
                    fall = true;
                }
              

                // Ako isceznalo prviot block dodadi go na location width + dupkata so a sakame
                if (pbFloor1.Location.X < -pbFloor1.Width)
                {
                    pbFloor1.Location = new Point(pbFloor2.Location.X + 200 + pbFloor2.Width, pbFloor2.Location.Y);
                    pbCoin2.Location = new Point(pbFloor1.Location.X - 100, pbCoin2.Location.Y);
                    pbCactus1.Location = new Point(pbFloor1.Location.X + (pbFloor1.Width / 2), pbCactus1.Location.Y);
                    pbCoin2.Visible = true;
                }

                if (pbFloor2.Location.X < -pbFloor2.Width)
                {
                    pbFloor2.Location = new Point(pbFloor1.Location.X + 200 + pbFloor1.Width, pbFloor1.Location.Y);
                    pbCoin1.Location = new Point(pbFloor2.Location.X - 100, pbCoin1.Location.Y);
                    pbCactus2.Location = new Point(pbFloor2.Location.X + (pbFloor2.Width / 2), pbCactus2.Location.Y);
                    pbCoin1.Visible = true;
                }

                //za koga pagja
                
                if (!isJumping && !jump && !(pbPlayer.Location.X  >=  pbFloor1.Location.X && pbPlayer.Location.X + 10 <= pbFloor1.Location.X + pbFloor1.Width) &&
                    !(pbPlayer.Location.X + pbPlayer.Width - 10 >= pbFloor1.Location.X && pbPlayer.Location.X + pbPlayer.Width - 15 <= pbFloor1.Location.X + pbFloor1.Width) &&
                    !(pbPlayer.Location.X >= pbFloor2.Location.X && pbPlayer.Location.X + 10 <= pbFloor2.Location.X + pbFloor2.Width) &&
                    !(pbPlayer.Location.X + pbPlayer.Width - 10 >= pbFloor2.Location.X && pbPlayer.Location.X + pbPlayer.Width - 15 <= pbFloor2.Location.X + pbFloor2.Width)

                    )
                {
                    fall = true;
                }

               // if (!isJumping &&
                  //  !isOverlap(pbPlayer.Location, pbPlayer.Width, pbPlayer.Height, pbFloor1.Location, pbFloor1.Width,
                  //      pbFloor1.Height) &&
                  //  !isOverlap(pbPlayer.Location, pbPlayer.Width, pbPlayer.Height, pbFloor2.Location, pbFloor2.Width,
                  //      pbFloor2.Height) ||
                 //   pbFloor1.Location.X + pbFloor1.Width < pbPlayer.Location.X + 30 && !isJumping ||
                 //   pbFloor2.Location.X + pbFloor2.Width < pbPlayer.Location.X + 30 && !isJumping)
             //   {
            //        fall = true;
             //   }

                lblScore.Text = lblCurrentScore.Text = Score.ToString();
            }
            else if (fall && !gameOver)
            {
                pbPlayer.Location = new Point(pbPlayer.Location.X, pbPlayer.Location.Y + 8);
                //A povikuvame move right oti samo platformite se mrdat vaka a ne i akktusite i parite
                moveRight();

                //Game Over
                if (pbPlayer.Location.Y + 120 >= 555)
                {
                   
                    gameOver = true;
                    handled = false;

                }
            }
        }

        public void endGame()
        {
            timer1.Enabled = false;
            gameOver = true;
            pause = true;
            jump = false;
            isJumping = false;
            pbCactus1.Visible = false;
            pbCactus2.Visible = false;
            cactusShow = false;
            if (Score > HighScore)
            {
                HighScore = Score;
                lbForlCenterHighScore.Text = "New High Score! ";
            }
            else
            {
                lbForlCenterHighScore.Text = "High Score: " + HighScore.ToString();
            }

            //lblCenterHighScore.Text = HighScore.ToString();
            buttonVisible(true);
            btnPlay.Text = "Play again";
            MOVE_DISTANCE = 9;

            pbPlayer.Visible = false;
            PlayAgain();
        }

        public bool isTouching(Point stick, Point cactus)

        {
            return stick.X + pbPlayer.Width >= cactus.X && stick.X < cactus.X && stick.Y + pbPlayer.Height >= cactus.Y;
        }
        //FUNKCI

        public void moveRight()
        {
            pbFloor1.Location = new Point(pbFloor1.Location.X - MOVE_DISTANCE, pbFloor1.Location.Y);
            pbFloor2.Location = new Point(pbFloor2.Location.X - MOVE_DISTANCE, pbFloor2.Location.Y);
            pbCoin1.Location = new Point(pbCoin1.Location.X - MOVE_DISTANCE, pbCoin1.Location.Y);
            pbCoin2.Location = new Point(pbCoin2.Location.X - MOVE_DISTANCE, pbCoin2.Location.Y);
            pbCactus2.Location = new Point(pbCactus2.Location.X - MOVE_DISTANCE, pbCactus2.Location.Y);
            pbCactus1.Location = new Point(pbCactus1.Location.X - MOVE_DISTANCE, pbCactus1.Location.Y);
            if (Score == 6)
            {
                pbCactus1.Visible = true;
                pbCactus2.Visible = true;
                cactusShow = true;

            }

            //namaluvanje na floor

            if (Score % 9 == 0 && Score != 0 && !decrementFloor)
            {
                decrementFloor = true;
            }

            if (decrementFloor && Score % 9 != 0)
            {
                decrementFloor = false;
                pbFloor1.Width -= 3;
                pbFloor2.Width -= 3;
                MOVE_DISTANCE += 1;
            }

            //Zgolemuvanje na MOVE_DISTANCE
            if (Score % 6 == 0 && Score != 0 && !addVelocity && MOVE_DISTANCE <= 11)
            {
                addVelocity = true;
            }

            if (addVelocity && Score % 6 != 0 && MOVE_DISTANCE <= 11)
            {
                addVelocity = false;
                MOVE_DISTANCE += 1;
            }
        }

        public void moveUp()
        {
            pbPlayer.Image = PlayerPHOTO;
            pbPlayer.Location = new Point(pbPlayer.Location.X, pbPlayer.Location.Y - 5);
            flying++;
            if (flying == 15)
            {
                jump = false;
            }
        }

        public void moveDown()
        {
           // pbPlayer.Image = PlayerPHOTO;
            pbPlayer.Location = new Point(pbPlayer.Location.X, pbPlayer.Location.Y + 5);
            flying--;
            if (flying == 0)
            {
                isJumping = false;
            }
        }

        public bool isOverlap(Point rectangle1, int widthRec1, int heightRec1, Point rectangle2, int widthRec2,
            int heightRec2)
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
            lbForlCenterHighScore.Text = "High Score: " + HighScore.ToString();
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

        public void changeSound()
        {
            if (pbSound.Image == SoundOn)
            {
                pbSound.Image = SoundOff;
                soundPlayer.Stop();
                soundPlayer.Load();
            }
            else
            {
                pbSound.Image = SoundOn;
                soundPlayer.Play();
            }
        }

        private void PbSound_Click(object sender, EventArgs e)
        {
            changeSound();
        }
    }

}
 

