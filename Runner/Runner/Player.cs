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
        public int width { get; set; }
        public int height { get; set; }



        public void Draw(Graphics g)
        {

        }

        public void moveRight()
        {
            if (center.X + 10 > width)
                center = new Point(width, center.Y);
            else
                center = new Point(center.X + 10, center.Y);
        }
        public void moveLeft()
        {
            if (center.X - 10 < 0)
                center = new Point(0, center.Y);
            else
                center = new Point(center.X - 10, center.Y);
        }

    }
}