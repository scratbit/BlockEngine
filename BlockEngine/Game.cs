using System;
using System.Drawing;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

using BlockEngine.Core.Hosts;
using BlockEngine.Core.Network;

namespace BlockEngine
{
    class Game
    {
        public static Client createClient(int id)
        {
            using (Client client = new Client())
            {
                client.Run(30, 60);
                client.clientID = id;
                return client;
            }
        }
    }
}