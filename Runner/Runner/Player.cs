using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner
{
    class Player
    {
        public Point center { get; set; }
        bool up, down;
        private int canUp, canDown;

        public Player()
        {
            up = true;
            canUp = 0;
            canDown = 100;
        }

        public void Draw(Graphics g)
        {
              
        }

        public void moveRight(int width)
        {
            if (center.X + 10 <= width - 70)
                center = new Point(center.X + 10, center.Y);
        }
        public void moveLeft()
        {
            if (center.X - 10 >= 0)
                center = new Point(center.X - 10, center.Y);
        }

        public bool isInJump()
        {
            if (canUp == 0)
                return false;
            return true;
        }

        public void Jump()
        {
            if (up)
            {
                if (canUp < 100)
                {
                    canUp += 20;
                    center = new Point(center.X, center.Y - 15);
                }
                else
                {
                    up = !up;
                }
            }
            else
            {
                if (canUp > 0)
                {
                    canUp -= 20;
                    center = new Point(center.X, center.Y + 15);
                }
                else
                {
                    canUp = 0;
                    up = !up;
                }
            }
       
        }
        
    }
}
