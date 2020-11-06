using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAINA
{
    class MyTrain : MyWagon
    {
        private int x;
        private int y;
        private int le;
        private int length;
        private MyWagon Wagon;
        private List<MyWagon> Wagons = new List<MyWagon>();
        public int wSum;

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
        public override int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public MyTrain(int x, int y, int le, int length) : base(x, y, le)
        {
            LEN = le;
            Length = length;
            WagonsAdding(x, y);
        }
        public override void Draw(Graphics G)
        {
            foreach (MyWagon item in Wagons)
            {
                item.Draw(G);
            }
        }
        public override void WagonsAdding(int x, int y)
        {
            Random rnd = new Random();
            Random rndWagon = new Random();
            for (int i = 1; i <= Length; i++)
            {
                int rndWag = rndWagon.Next(2);
                if (rndWag == 1)
                {
                    Wagon = new CoalWagon(x, y, LEN);
                    Wagon.Weight = rnd.Next(100);
                    Wagons.Add(Wagon);
                    x += (Wagon.Width + 4);
                }
                if (rndWag == 0)
                {
                    Wagon = new SandWagon(x, y, LEN);
                    Wagon.Weight = rnd.Next(100);
                    Wagons.Add(Wagon);
                    x += (Wagon.Width + 4);
                }
                
            }
        }
        public override void Move(int beginX, int BeginY, int XX, int YY)
        {
            foreach (MyWagon item in Wagons)
            {
                item.Move(beginX, BeginY, XX, YY);

                XX += (item.Width + 4);
            }
        }
        public override bool IsPointInside(int XX, int YY)
        {
            foreach (MyWagon item in Wagons)
            {
                if (item.IsPointInside(XX, YY)) { return true; }
                return false;
            }
            return false;
        }
        public override int WeightSum()
        {
            foreach(MyWagon item in Wagons)
            {
                wSum += item.Weight;
            }
            return wSum;
        }
    }
}
