using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2._1
{
    public class MyPoint
    {
        private int x, y;
        public MyPoint()
        {
            this.x = this.y = 0;
        }
        public MyPoint(int X, int Y)
        {
            this.x = X;
            this.y = Y;
        }
        public int GetX()
        {
            return this.x;
        }

        public void SetX(int X)
        {
            this.x = X;
        }
        public int GetY()
        {
            return this.y;
        }

        public void SetY(int Y)
        {
            this.y = Y;
        }

        public int[] GetXY()
        {
            return new int [] {this.x, this.y};
        }

        public void SetXY(int X, int Y)
        {
            this.x = X;
            this.y = Y;
        }

        public override string ToString()
        {
            return String.Format("({{0}, {1})", this.x, this.y);
        }

        public double Distance(int X, int Y)
        {
            return Math.Sqrt(Math.Pow(this.x - X, 2) + Math.Pow(this.y - Y, 2));
        }

        public double Distance(MyPoint point)
        {
            return Distance(point.GetX(), point.GetY());
        }

        public double Distance()
        {
            return Distance(0,0);
        }
    }
}
