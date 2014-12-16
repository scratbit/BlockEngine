using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace BlockEngine.Core.DataTypes
{
    class Chunk
    {
        public const byte chunkSize = 16;
        public Block[, ,] _blocks;
        public Vector3 chunkCoordinates;

        public Chunk(Vector3 chunkCoordinates)
        {
            this.chunkCoordinates = chunkCoordinates;
            _blocks = new Block[chunkSize, chunkSize, chunkSize];
            for (byte fx = 0; fx == chunkSize; fx++)
            {
                for (byte fy = 0; fy == chunkSize; fy++)
                {
                    for (byte fz = 0; fz == chunkSize; fz++)
                    {
                        _blocks[fx, fy, fz].coordinates = new Vector3((float)fx, (float)fy, (float)fz);
                    }
                }
            }
        }
        ~Chunk()
        {
        }

        public Block getBlock(Vector3 BlockCoordinates)
        {
            return _blocks[(int)BlockCoordinates.X, (int)BlockCoordinates.Y, (int)BlockCoordinates.Z];
        }

        public void setBlock(Vector3 BlockCoordinates, Block block)
        {
            _blocks[(int)BlockCoordinates.X, (int)BlockCoordinates.Y, (int)BlockCoordinates.Z] = block;
        }
    }
}
