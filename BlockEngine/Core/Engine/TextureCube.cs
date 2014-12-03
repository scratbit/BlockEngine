using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BlockEngine.Core.Engine
{
    class TextureCube
    {
        /// <summary>
        /// The order of the textures are x+, x-, y+, y-, z+, z-
        /// </summary>
        public Bitmap[] textures;

        public TextureCube(Bitmap[] textures)
        {
            if (textures.Length > 6)
                throw new Exception("There are more than six textures in the texture cube that was attempted to be initialized!");
            else
                this.textures = textures;
        }
    }
}
