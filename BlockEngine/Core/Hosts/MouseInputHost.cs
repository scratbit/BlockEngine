using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using OpenTK;
using OpenTK.Input;

namespace BlockEngine.Core.Hosts
{
    class MouseInputHost
    {
        public Vector2 mouseSpeed;
        public Vector2 mouseDelta;
        public Vector2 mousePosition;
        public Point windowCenter;

        public void OnMouseMove(object sender, MouseMoveEventArgs e)
        {
            mousePosition = new Vector2(e.X, e.Y);
        }
    }
}
