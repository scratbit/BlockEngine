using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockEngine.Core.Engine
{
    /// <summary>
    /// Represents a point in 3D space with the fourth dimension representing time (a 3D point that moves)
    /// </summary>
    class Point4D
    {
        public Point3D[] Time;
        public Point4D(Point3D[] Points)
        {
            this.Time = Points;
        }
    }
}
