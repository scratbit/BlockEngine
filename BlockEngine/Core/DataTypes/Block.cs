using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockEngine.Core.DataTypes
{
    class Block
    {
        public BlockProperties properties;

        public Block(BlockProperties properties)
        {
            this.properties = properties;
        }
    }
}
