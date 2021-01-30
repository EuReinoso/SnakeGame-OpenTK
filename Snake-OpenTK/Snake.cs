using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Snake_OpenTK
{
    class Snake
    {
        
        public int size = new int();
        public float r = new float();
        public float g = new float();
        public float b = new float();

        public Snake(int size,float r, float g, float b)
        {
            this.size = size;
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public void printSnake()
        {
            new DrawRect(size, size, 0, 0, r, g, b).printRect();
            
        }
    }
}
