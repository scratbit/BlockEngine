using System;
using System.Drawing;
using System.Drawing.Imaging;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

using BlockEngine.Core.Hosts;

namespace BlockEngine.Core.Network
{
    class Client : GameWindow
    {
        public int clientID;
        RenderHost renderer = new RenderHost();
        MouseInputHost mouseIn = new MouseInputHost();

        public Client()
            : base(1024, 768, GraphicsMode.Default, "BlockEngine")
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            renderer.init();
            mouseIn.windowCenter = new Point(Bounds.Left + Bounds.Width / 2, Bounds.Top + Bounds.Height / 2);
            MouseMove += new EventHandler<MouseMoveEventArgs>(mouseIn.OnMouseMove);

            loadTexture("grass.bmp");
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height);

            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView((float)Math.PI / 4, Width / (float)Height, 1.0f, 64.0f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            #region Camera

            #endregion

            KeyDown += new EventHandler<KeyboardKeyEventArgs>(destroyGame);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.MatrixMode(MatrixMode.Modelview);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            #region Draw

            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(0.0f, 0.0f);
            GL.Vertex2(0.0f, 0.0f);
            GL.TexCoord2(1.0f, 0.0f);
            GL.Vertex2(1.0f, 0.0f);
            GL.TexCoord2(0.0f, 1.0f);
            GL.Vertex2(0.0f, 1.0f);
            GL.TexCoord2(1.0f, 1.0f);
            GL.Vertex2(1.0f, 1.0f);
            GL.End();

            #endregion

            SwapBuffers();
        }

        void destroyGame(object sender, KeyboardKeyEventArgs e)
        {
            Exit();
        }
        int loadTexture(string filename)
        {
            if (String.IsNullOrEmpty(filename))
                throw new ArgumentException(filename);

            int id = GL.GenTexture();
            GL.BindTexture(TextureTarget.Texture2D, id);

            // We will not upload mipmaps, so disable mipmapping (otherwise the texture will not appear).
            // We can use GL.GenerateMipmaps() or GL.Ext.GenerateMipmaps() to create
            // mipmaps automatically. In that case, use TextureMinFilter.LinearMipmapLinear to enable them.
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);

            Bitmap bmp = new Bitmap(filename);
            BitmapData bmp_data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, bmp_data.Width, bmp_data.Height, 0,
                OpenTK.Graphics.OpenGL.PixelFormat.Bgra, PixelType.UnsignedByte, bmp_data.Scan0);

            bmp.UnlockBits(bmp_data);

            return id;
        }
    }
}
