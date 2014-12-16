using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace BlockEngine.Core.DataTypes
{
    class Block
    {
        public BlockProperties properties;
        public Vector3 coordinates;

        public Block(BlockProperties properties, Vector3 coordinates)
        {
            this.properties = properties;
            this.coordinates = coordinates;
        }
        ~Block()
        {

        }
    }
}
