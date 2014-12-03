using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockEngine.Core.Engine
{
    /// <summary>
    /// Represents a point in a 2D space
    /// </summary>
    class Point2D
    {
        public float X;
        public float Y;
        public Point2D(long X, long Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public Point2D(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public Point2D(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public Point2D(double X, double Y)
        {
            this.X = (float)X;
            this.Y = (float)Y;
        }
        public Point2D(short X, short Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
