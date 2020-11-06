using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAINA
{
    class MyWagon : MyFigure
    {
        private MyRectangle Body;
        private MyCircle WH1, WH2;
        private int le = 2;
        private int width;
        private int height;
        private int weight;
        private int x;
        private int y;
        private int radius;       
        private Random random = new Random();
        private CoalWagon Coal;

        public override int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public override int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public override int LEN
        {
            get
            {
                return le;
            }
            set
            {
                le = value;
            }
        }
        public override int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        public override int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public override int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }


        public override int Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public MyWagon(int x, int y, int le)
        {
            LEN = le;

            height = le / 2;

            width = le;

            weight = random.Next(100);

            radius = width / 5;

            Body = new MyRectangle(x, y, width, height);

            WH1 = new MyCircle(x - width / 3, y + height / 2 + (width / 5) / 2 + 1, radius);

            WH2 = new MyCircle(x + width / 3, y + height / 2 + (width / 5) / 2 + 1, radius);
        }
        public override void Draw(Graphics G)
        {
            Body.Draw(G);
            WH1.Draw(G);
            WH2.Draw(G);
            G.DrawString(Convert.ToString(weight), new Font("Arial", LEN / 4), Brushes.Black, Body.X - LEN / 4, Body.Y - LEN / 4);
        }
        public override void Move(int beginX, int beginY, int XX, int YY)
        {
            Body.X = XX - x;
            Body.Y = YY - y;
            WH1.X = XX - x - width / 4;
            WH1.Y = YY - y + height / 2 + (width / 5) / 2 + 2;
            WH2.X = XX - x + width / 4;
            WH2.Y = YY - y + height / 2 + (width / 5) / 2 + 2;
        }
        public override bool IsPointInside(int dX, int dY)
        {
            if (Body.IsPointInside(dX, dY))
            {
                return true;
            }

            if (WH1.IsPointInside(dX, dY))
            {
                return true;

            }

            if (WH2.IsPointInside(dX, dY))
            {
                return true;
            }
            else { return false; }
        }
    }
}
