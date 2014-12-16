using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Threading;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

using BlockEngine.Core.Network;

namespace BlockEngine
{
    class Program
    {
        static Client client;
        static Random r = new Random((DateTime.Now.Second * DateTime.Now.Minute) - DateTime.Now.Second);

        static void Main()
        {
            client = Game.createClient(r.Next(int.MaxValue));
        }
    }
}