using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockEngine.Core.Engine
{
    /// <summary>
    /// Represents either a point in a 3D space or a 2D point with the third dimension being time (a 2D point that moves)
    /// </summary>
    class Point3D
    {
        public float X;
        public float Y;
        public float Z;
        public Point2D[] Time;
        public Point3D(long X, long Y, long Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
        public Point3D(int X, int Y, int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
        public Point3D(short X, short Y, short Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
        public Point3D(float X, float Y, float Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
        public Point3D(double X, double Y, double Z)
        {
            this.X = (float)X;
            this.Y = (float)Y;
            this.Z = (float)Z;
        }
        public Point3D(Point2D[] Points)
        {
            this.Time = Points;
        }
    }
}
