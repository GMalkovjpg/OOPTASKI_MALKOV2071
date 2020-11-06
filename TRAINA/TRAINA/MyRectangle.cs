using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAINA
{
    class MyRectangle : MyFigure
    {
        private int width = 2;
        private int height = 2;
        private int beginX = 0;
        private int beginY = 0;
        private Color color = Color.Black;

        public override Color CALOR
        {
            get { return color; }
            set { color = value; }
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

        public override int Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0 && value <= 500)
                {
                    width = value;
                }
                else { throw new Exception("Диапазон ширины от 0 до 500"); }
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
                if (value > 1 && value <= 500)
                {
                    height = value;
                }
            }
        }

        public MyRectangle(int x, int y, int width, int height)
        {
            this.beginX = x;
            this.beginY = y;
            this.width = width;
            this.height = height;
        }

        public override void Move(int deX, int deY, int XX, int YY)
        {
            base.Move(deX, deY, XX, YY);
        }

        public override void Draw(Graphics G)
        {
            G.DrawRectangle(new Pen(new SolidBrush(CALOR), 2), beginX - Width / 2, beginY - Height / 2, Width, Height);
        }
        public override void DrawCargo(Graphics G)
        {
            G.FillRectangle(new SolidBrush(CALOR), beginX - Width / 2, beginY - Height / 2, Width, Height);
        }

        public override bool IsPointInside(int x, int y)
        {
            if ((x > this.beginX - Width / 2) && (x < this.beginX + Width / 2) && (y > this.beginY - Height / 2) && (y < this.beginY + Height / 2))
            {
                return true;
            }
            else { return false; }
        }
    }
}