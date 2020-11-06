using System.Drawing;

namespace TRAINA
{
    class MyFigure
    {
        
        public virtual int Radius { get; set; }    
        public virtual int LEN { get; set; }
        public virtual int X { get; set; }
        public virtual int Y { get; set; }
        public virtual int Length { get; set; }
        public virtual int Weight { get; set; }
        public virtual Color CALOR { get; set; }
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public virtual void WagonsAdding(int x, int y) 
        {

        }
        public virtual void Draw(Graphics G)
        {
        }
        public virtual void DrawCargo(Graphics G) { }
        public virtual void Move(int DX, int DY, int XX, int YY)
        {
            X = XX - DX;
            Y = YY - DY;
        }
        public virtual bool IsPointInside(int x, int y)
        {
            return false;
        }
        public virtual int WeightSum()
        {
            return 0;
        }
    }
}
