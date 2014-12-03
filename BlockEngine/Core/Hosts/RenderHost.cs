using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace BlockEngine.Core.Hosts
{
    class RenderHost
    {
        #region
        public float[] cube = {
			 0.0f,  1.0f,  1.0f, // vertex[0]
			 1.0f,  1.0f,  1.0f, // vertex[1]
			 1.0f,  0.0f,  1.0f, // vertex[2]
			 0.0f,  0.0f,  1.0f, // vertex[3]
			 0.0f,  1.0f,  0.0f, // vertex[4]
			 1.0f,  1.0f,  0.0f, // vertex[5]
			 1.0f,  0.0f,  0.0f, // vertex[6]
			 0.0f,  0.0f,  0.0f, // vertex[7]
		};
        float[] cubeColors = {
			1.0f, 0.0f, 0.0f, 1.0f,
			0.0f, 1.0f, 0.0f, 1.0f,
			0.0f, 0.0f, 1.0f, 1.0f,
			0.0f, 1.0f, 1.0f, 1.0f,
			1.0f, 0.0f, 0.0f, 1.0f,
			0.0f, 1.0f, 0.0f, 1.0f,
			0.0f, 0.0f, 1.0f, 1.0f,
			0.0f, 1.0f, 1.0f, 1.0f,
		};
        byte[] triangles =
		{
			1, 0, 2, // front
			3, 2, 0,
			6, 4, 5, // back
			4, 6, 7,
			4, 7, 0, // left
			7, 3, 0,
			1, 2, 5, //right
			2, 6, 5,
			0, 1, 5, // top
			0, 5, 4,
			2, 3, 6, // bottom
			3, 7, 6,
		};
        #endregion

        public RenderHost()
        {

        }
        ~RenderHost()
        {
        }

        public void init()
        {
            GL.ClearColor(Color.CornflowerBlue);
            GL.Enable(EnableCap.DepthTest);
            GL.Enable(EnableCap.CullFace);
            GL.EnableClientState(ArrayCap.VertexArray);
            GL.EnableClientState(ArrayCap.ColorArray);
        }

        public void renderBlock()
        {
            GL.VertexPointer(3, VertexPointerType.Float, 0, cube);
            GL.ColorPointer(4, ColorPointerType.Float, 0, cubeColors);
            GL.DrawElements(PrimitiveType.Triangles, triangles.Length, DrawElementsType.UnsignedByte, triangles);
        }

        public void renderChunk()
        {

        }
    }
}
