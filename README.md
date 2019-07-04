<p align="center">
    <img width=40% src="Runner/Runner/images/logo1.png?raw=true" alt="Лого на играта/Game logo">
</p>

<h1 align="center">Runner</h1>

---

## Содржина

* [Краток опис на играта](#Краток-опис-на-играта)
* [Упатство за користење](#Упатство-за-користење)
* [Дел од проблемите и дел од кодот](#Дел-од-проблемите-и-дел-од-кодот)
* [Користени библиотеки](#Користени-библиотеки)

<br>

## Краток опис на играта

Интересна,0+ заразна игра каде собираш поени, и постојано пробуваш да го собориш својот рекорд. Играта се состои од стикмен кој собира парички и прескокнува платформи за да не падне. Во текот на играта се појавуваат и кактуси кои треба да ги прескокне за да не заврши играта. Исто така при собирање на повеќе парички платформите почнуваат да се намалуваат се со цел играта да стане потешка.

## Упатство за користење

Човекот кој треба да го придвижуваш се придвижува при притискање на стрелката надесно, а за скокање се користи стрелката нагоре или Space копчето. Исто така, додека човекот е во скок, обидот за повторно скокање ќе биде неуспешен со цел да не лета во воздухот. Секогаш ќе може да скока само ако е на платформата.

## Дел од проблемите и дел од кодот

  * При притискање на копчето за придвижување надесно, ја повикуваме функцијата за придвижување, така што ги придвижуваме сите објекти освен човекот, со што добиваме виртуелно трчање на човекот. Исто така во оваа функција кога ќе достигнеме 6 парички ги прикажуваме кактусите, а на секои 9 парички ja намалуваме големината на платформата и ја зголемуваме брзината на движење со цел играта да стане потешка.
  ```C# public void moveRight()
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
  ```  
  * При скокање повикуваме две функции, една за човекот да се придвижи нагоре, а друга за да се придвижи надоле.
  ```C#
public void moveUp()
        {
            pbPlayer.Image = PlayerPHOTO;
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 5);
            flying++;
            if (flying == 15)
            {
                jump = false;
            }
        }

public void moveDown()
        {
            pbPlayer.Image = PlayerPHOTO;
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 5);
            flying--;
            if (flying == 0)
            {
                isJumping = false;
            }
        }

  ```

  * При допирање на кактус или при паѓање се повикува функцијата endGame();

  ```C#
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
```

* Проблемот за бесконечно појавување на платформата за трчање е решен така што кога човекот прескокнува дупка платформата позади него се губи, но на одредена далечина се појавува нова платформа.

```C#
 
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
  ```
  * При затварање на играта со отвара конфирмациски диалог со прашање дали сте сигурни дека сакате да се исклучи играта. Автоматски кај секој корисник во **Documents** се зачувува **High Score**, но фајлот е скриен (hidden) за да неможе да го примети секој.
  ```C#
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
  ```

  * Исто така при лоадирање на играта се проверува дали има зачувано **highscore.bin**, ако има се превземаат податоците и се прикажува претходниот **high score**.
  ```C#
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
  ```
<br>
**Напомена оваа се само мал дел од проблемите кои ги имавме при имплементација!**

## Користени библиотеки
<br>
Најголем дел од решенијата на проблемите со кои се соочувавме беа пронајдени:

  * [stackoverflow](https://stackoverflow.com/)
  * [geeksforgeeks](https://www.geeksforgeeks.org/)
  * [google](https://www.google.com/)

<br>
<hr>

### Изработиле:
  1. Кирил Ристов - 173217
  2. Антонио Славкоски - 161152
  3. Венко Стојанов - 173189
