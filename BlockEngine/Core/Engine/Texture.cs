using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BlockEngine.Core.Engine
{
    class Texture
    {
        public Texture(Bitmap texture)
        {
            this.texture = texture;
        }
        public Bitmap texture;
    }
}
