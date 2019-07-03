<p align="center">
    <img width=40% src="Runner/Runner/images/background.png?raw=true" alt="Лого на играта/Game logo">
</p>

<h1 align="center">Runner</h1>

---

## Содржина

* [Краток опис на играта](#Краток-опис-на-играта)
* [Упатство за користење](#Упатство-за-користење)
* [Дел од проблемите и дел од кодот](#Дел=од-проблемите-и-дел-од-кодот)
* [Користени библиотеки](#Користени-библиотеки)

<br>

## 1. Краток опис на играта

Интересна заразна игра каде собираш поени, и постојано пробуваш да го собориш својот рекорд. Играта се состои од стикмен кои собира парички и прескокнува платформи за да не падни во текот на играта се појавуваат и кактуси кои треба да ги прескокни за да не заврши играта исто така при собирање на повеќе парички платформите почнуваат да се намалуваат се со цел да се отежни играта.

## 2. Упатство за користење

Човекот кој треба да го придвижуваш се придвижува при притискање на стрелката надесно, а за скокање се користи стрелката нагоре или Space копчето. Исто така човекот додека е во скок при притискање на копчето за скокање тоа нема да биде успешно со цел да не лета во воздухот, секогаш ќе може да прескокнува само ако е на платформата.

## 3. Дел од проблемите и дел од кодот

  * При притискање на копчето за придвижување надесно ние ја повикуваме функцијата за придвижување, така што ние ги придвижуваме сите објекти освен човекот со тоа добиваме како човекот да трчи. Исто така во оваа функција кога ќе достигнеме 8 парички ние ги прикажуваме кактусите за да се отежни играта, а на секои 12 парички го намалуваме големината на платформата.
  ```C#
  		public void moveRight()
        {
            floor.Location = new Point(floor.Location.X - 7, floor.Location.Y);
            floor2.Location = new Point(floor2.Location.X - 7, floor2.Location.Y);
            pictureBoxCoin1.Location = new Point(pictureBoxCoin1.Location.X - 7, pictureBoxCoin1.Location.Y);
            pictureBoxCoin2.Location = new Point(pictureBoxCoin2.Location.X - 7, pictureBoxCoin2.Location.Y);
            pictureBoxCactus2.Location = new Point(pictureBoxCactus2.Location.X - 7, pictureBoxCactus2.Location.Y);
            pictureBoxCactus1.Location = new Point(pictureBoxCactus1.Location.X - 7, pictureBoxCactus1.Location.Y);
            if (Score == 8)
            {
                pictureBoxCactus1.Visible = true;
                pictureBoxCactus2.Visible = true;
            }

            //namaluvanje na floor

            if (Score % 12 == 0 && Score != 0 && !decrementFloor)
            {
                decrementFloor = true;
            }

            if (decrementFloor && Score % 12 != 0)
            {
                decrementFloor = false;
                floor.Width -= 3;
                floor2.Width -= 3;
            }
        }

  ```  
  * При скокање ги повикуваме две функции една за човекот да се придвижи нагоре а друга за да се придвижи надоле.
  ```C#
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

  ```

  * При допирање на кактус или при паѓање се повикува функцијата endGame();

  ```C#
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
```

* Проблемот за бесконечно појавување на платформата за трчање е решен така што чим исчезни платформата да се појави на одредена далечина од останатата платформа.
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
<br>
Напомена оваа се само мал дел од проблемите кои ги имавме при имплементација.

## 4. Користени библиотеки
<br>
Најголем дел од проблемите со кои се соочувавме беа пронајдени:

  * [stackoverflow](https://stackoverflow.com/)
  * [geeksforgeeks](https://www.geeksforgeeks.org/)
  * [google](https://www.google.com/)