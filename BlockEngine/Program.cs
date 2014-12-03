using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace BlockEngine
{
    class Program
    {
        static void Main()
        {
            using (Game game = new Game())
            {
                game.Run(30, 30);
            }
        }
    }
}