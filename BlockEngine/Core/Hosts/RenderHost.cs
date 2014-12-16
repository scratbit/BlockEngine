using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

using OpenTK;
using OpenTK.Graphics.OpenGL;

using BlockEngine.Core.DataTypes;

namespace BlockEngine.Core.Hosts
{
    class RenderHost
    {
        /*
        #region
        public static Vector3[] cube = {
			 new Vector3(0.0f,  1.0f,  1.0f), // vertex[0]
			 new Vector3(1.0f,  1.0f,  1.0f), // vertex[1]
			 new Vector3(1.0f,  0.0f,  1.0f), // vertex[2]
			 new Vector3(0.0f,  0.0f,  1.0f), // vertex[3]
			 new Vector3(0.0f,  1.0f,  0.0f), // vertex[4]
			 new Vector3(1.0f,  1.0f,  0.0f), // vertex[5]
			 new Vector3(1.0f,  0.0f,  0.0f), // vertex[6]
			 new Vector3(0.0f,  0.0f,  0.0f), // vertex[7]
		};
        static float[] cubeColors = {
			1.0f, 0.0f, 0.0f, 1.0f,
			0.0f, 1.0f, 0.0f, 1.0f,
			0.0f, 0.0f, 1.0f, 1.0f,
			0.0f, 1.0f, 1.0f, 1.0f,
			1.0f, 0.0f, 0.0f, 1.0f,
			0.0f, 1.0f, 0.0f, 1.0f,
			0.0f, 0.0f, 1.0f, 1.0f,
			0.0f, 1.0f, 1.0f, 1.0f,
		};
        static byte[] triangles =
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
            GL.ClearColor(0.2f, 0.3f, 0.6f, 1.0f);
            GL.Enable(EnableCap.DepthTest);
            GL.Enable(EnableCap.CullFace);
            GL.EnableClientState(ArrayCap.VertexArray);
            GL.EnableClientState(ArrayCap.ColorArray);
        }

        public void renderBlock(Vector3[] vp)
        {
            GL.PushMatrix();
            GL.VertexPointer(3, VertexPointerType.Float, 0, vp);
            GL.ColorPointer(4, ColorPointerType.Float, 0, cubeColors);
            GL.DrawElements(PrimitiveType.Triangles, triangles.Length, DrawElementsType.UnsignedByte, triangles);
            GL.PopMatrix();
        }

        public void renderChunk(DataTypes.Chunk chunk)
        {
            Vector3[] vp = new Vector3[8];

            for (int fx = 0; fx < Chunk.chunkSize; fx++)
            {
                for (int fy = 0; fy < Chunk.chunkSize; fy++)
                {
                    for (int fz = 0; fz < Chunk.chunkSize; fz++)
                    {
                        float posX = (chunk.chunkCoordinates.X * Chunk.chunkSize) + fx;
                        float posY = (chunk.chunkCoordinates.Y * Chunk.chunkSize) + fy;
                        float posZ = (chunk.chunkCoordinates.Z * Chunk.chunkSize) + fz;

                        /* new Vector3(0.0f,  1.0f,  1.0f), // vertex[0]
			               new Vector3(1.0f,  1.0f,  1.0f), // vertex[1]
			               new Vector3(1.0f,  0.0f,  1.0f), // vertex[2]
			               new Vector3(0.0f,  0.0f,  1.0f), // vertex[3]
			               new Vector3(0.0f,  1.0f,  0.0f), // vertex[4]
			               new Vector3(1.0f,  1.0f,  0.0f), // vertex[5]
			               new Vector3(1.0f,  0.0f,  0.0f), // vertex[6]
			               new Vector3(0.0f,  0.0f,  0.0f), // vertex[7]

                        vp[0] = new Vector3(posX, posY + 1.0f, posZ + 1.0f);
                        vp[1] = new Vector3(posX + 1.0f, posY + 1.0f, posZ + 1.0f);
                        vp[2] = new Vector3(posX + 1.0f, posY, posZ + 1.0f);
                        vp[3] = new Vector3(posX, posY, posZ + 1.0f);
                        vp[4] = new Vector3(posX, posY + 1.0f, posZ);
                        vp[5] = new Vector3(posX + 1.0f, posY + 1.0f, posZ);
                        vp[6] = new Vector3(posX + 1.0f, posY, posZ);
                        vp[7] = new Vector3(posX, posY, posZ);

                        renderBlock(vp);
                    }
                }
            }
        }
        */

        public void init()
        {
            GL.ClearColor(Color.CornflowerBlue);
            GL.Enable(EnableCap.DepthTest);
            GL.Enable(EnableCap.CullFace);
            GL.EnableClientState(ArrayCap.VertexArray);
            GL.EnableClientState(ArrayCap.ColorArray);
        }
    }
}
