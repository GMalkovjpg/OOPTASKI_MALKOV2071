using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAINA
{
    class SandWagon : MyWagon
    {
        private MyRectangle BODY;
        private MyRectangle Cargo;
        private MyCircle WL1, WL2;
        private int le = 2;
        private int width;
        private int radius;
        private int height;
        private int weight;
        private int x;
        private int y;
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
        public SandWagon(int x, int y, int l) : base(x, y, l)
        {
            LEN = l;
            radius = width / 5;
            weight = random.Next(100);
            width = l;
            height = l / 2;
            Cargo = new MyRectangle(x, y - (height - 2), width - 4, height / 2);
            BODY = new MyRectangle(x, y, width, height);
            Cargo.CALOR = Color.Black;
            WL1 = new MyCircle(x - width / 3, y + height / 2 + (width / 5) / 2 + 1, radius);
            WL2 = new MyCircle(x + width / 3, y + height / 2 + (width / 5) / 2 + 1, radius);

        }
        public override void Draw(Graphics G)
        {
            BODY.Draw(G);
            Cargo.DrawCargo(G);
            WL1.Draw(G);
            WL2.Draw(G);
            G.DrawString(Convert.ToString(weight), new Font("Arial", LEN / 4), Brushes.Black, BODY.X - LEN / 4, BODY.Y - LEN / 4);
        }
        public override void Move(int beginX, int beginY, int XX, int YY)
        {
            BODY.X = XX - x;
            BODY.Y = YY - y;
            Cargo.X = XX - x;
            Cargo.Y = YY + (y - (height - 2));
            WL1.X = XX - x - width / 4;
            WL1.Y = YY - y + height / 2 + (width / 5) / 2 + 2;
            WL2.X = XX - x + width / 4;
            WL2.Y = YY - y + height / 2 + (width / 5) / 2 + 2;
        }
        public override bool IsPointInside(int dX, int dY)
        {
            if (BODY.IsPointInside(dX, dY))
            {
                return true;
            }

            if (WL1.IsPointInside(dX, dY))
            {
                return true;
            }

            if (Cargo.IsPointInside(dX, dY))
            {
                return true;
            }

            if (WL2.IsPointInside(dX, dY))
            {
                return true;
            }
            else { return false; }
        }
    }
}
