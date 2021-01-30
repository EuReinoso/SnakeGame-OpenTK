using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Snake_OpenTK
{
    class Game:GameWindow
    {
        public int height = new int();
        public int width = new int();
        public string title = null;

        public Game(int width,int height,string title):base(width, height, GraphicsMode.Default, title)
        {
            this.title = title;
            this.width = width;
            this.height = height;
        }

        


        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Viewport(0, 0, ClientSize.Width, ClientSize.Height);

            Matrix4 projection = Matrix4.CreateOrthographic(ClientSize.Width, ClientSize.Height, 0.0f, 1.0f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);

            GL.Clear(ClearBufferMask.ColorBufferBit);

            SwapBuffers();
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            
        }
    }
}
