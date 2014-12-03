using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockEngine.Core.DataTypes
{
    class Chunk
    {
        private Block[, ,] _blocks;
        private Core.Engine.Point3D _chunkCoordinates;

        public Chunk(Block[,,] blocks, Core.Engine.Point3D chunkCoordinates)
        {
            this._blocks = blocks;
            this._chunkCoordinates = chunkCoordinates;
        }
        ~Chunk()
        {
        }

        public Block getBlock(Core.Engine.Point3D BlockCoordinates)
        {
            return _blocks[BlockCoordinates.X, BlockCoordinates.Y, BlockCoordinates.Z];
        }

        public void setBlock(Core.Engine.Point3D BlockCoordinates, Block block)
        {
            _blocks[BlockCoordinates.X, BlockCoordinates.Y, BlockCoordinates.Z] = block;
        }
    }
}
