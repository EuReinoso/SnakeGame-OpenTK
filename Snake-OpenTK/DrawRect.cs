using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Snake_OpenTK
{
    class DrawRect
    {
        public int width = new int();
        public int height = new int();
        public int xPos = new int();
        public int yPos = new int();
        public float r = new float();
        public float g = new float();
        public float b = new float();

        public DrawRect(int width, int height,int x, int y,float r,float g, float b)
        {
            this.width = width;
            this.height = height;
            this.xPos = x;
            this.yPos = y;
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public void printRect()
        {
            GL.Color3(r, g, b);

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex2(-0.5f * width + xPos , -0.5f * height + yPos);
            GL.Vertex2(0.5f * width + xPos, -0.5f * height + yPos);
            GL.Vertex2(0.5f * width + xPos, 0.5f * height + yPos);
            GL.Vertex2(-0.5f * width + xPos, 0.5f * height + yPos);
            GL.End();
        }
    }
}
