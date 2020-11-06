using System;
using System.Drawing;

namespace TRAINA
{
    class MyCircle : MyFigure
    {
        private int radious = 2;
        private int beginX = 0;
        private int beginY = 0;
        private Color color = Color.Black;

        public override int Radius
        {
            get
            {
                return radious;
            }
            set
            {
                radious = value;
            }
        }

        public override int X
        {
            get
            {
                return beginX;
            }
            set
            {
                beginX = value;
            }
        }

        public override int Y
        {
            get
            {
                return beginY;
            }
            set
            {
                beginY = value;
            }
        }

        public override Color CALOR
        {
            get { return color; }
            set { color = value; }
        }

        public MyCircle(int x, int y, int radious)
        {
            this.beginX = x;
            this.beginY = y;
            this.radious = radious;
        }

        public override void Move(int deX, int deY, int dX, int dy)
        {
            base.Move(deX, deY, dX, dy);
        }
        public override void Draw(Graphics G)
        {
            G.DrawEllipse(new Pen(new SolidBrush(CALOR), 3), beginX - Radius / 2, beginY - Radius / 2, Radius, Radius);
        }

        public override bool IsPointInside(int x, int y)
        {
            if (Math.Pow((x - this.beginX), 2) + Math.Pow((y - this.beginY), 2) <= Math.Pow(Radius / 2, 2))
            {
                return true;
            }
            else { return false; }
        }
    }
}