using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAINA
{
    class CoalWagon : MyWagon
    {
        private MyRectangle Body;
        private MyRectangle Cargo;
        private MyCircle WH1, WH2;
        private int le = 2;
        private int width ;
        private int height;
        private int x;
        private int y;
        private int radius;
        private int weight;
        private Random random = new Random();

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
        public CoalWagon(int x, int y, int le) : base(x, y, le)
        {
            LEN = le;

            height = le / 2;

            width = le;

            weight = random.Next(100);

            radius = width / 5;

            Body = new MyRectangle(x, y, width, height);
            Cargo = new MyRectangle(x, y - (height-2), width - 4, height / 2);
            Cargo.CALOR = Color.Orange;
            WH1 = new MyCircle(x - width / 3, y + height / 2 + (width / 5) / 2 + 1, radius);

            WH2 = new MyCircle(x + width / 3, y + height / 2 + (width / 5) / 2 + 1, radius);
        }
        public override void Draw(Graphics G)
        {
            Body.Draw(G);
            Cargo.DrawCargo(G);
            WH1.Draw(G);
            WH2.Draw(G);
            G.DrawString(Convert.ToString(weight), new Font("Arial", LEN / 4), Brushes.Black, Body.X - LEN / 4, Body.Y - LEN / 4);
        }
        public override void Move(int beginX, int beginY, int eX, int eY)
        {
            Body.X = eX - x;
            Body.Y = eY - y;
            Cargo.X = eX - x;
            Cargo.Y = eY + (y - (height - 2));
            WH1.X = eX - x - width / 4;
            WH1.Y = eY - y + height / 2 + (width / 5) / 2 + 2;
            WH2.X = eX - x + width / 4;
            WH2.Y = eY - y + height / 2 + (width / 5) / 2 + 2;
        }
        public override bool IsPointInside(int Dx, int Dy)
        {
            if (Body.IsPointInside(Dx, Dy))
            {
                return true;
            }

            if (WH1.IsPointInside(Dx, Dy))
            {
                return true;
            }

            if (Cargo.IsPointInside(Dx, Dy))
            {
                return true;
            }

            if (WH2.IsPointInside(Dx, Dy))
            {
                return true;

            }
            else { return false; }
        }
    }
}
