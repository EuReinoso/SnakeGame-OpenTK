using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace Snake_OpenTK
{
    class Snake
    {
        
        public int size = new int();
        public float r = new float();
        public float g = new float();
        public float b = new float();
        public int[] pos = new int[2];
        public int snakeDir = new int();

        

        public Snake(int size,int x,int y,float r, float g, float b)
        {
            this.size = size;
            this.r = r;
            this.g = g;
            this.b = b;
            this.pos[0] = x;
            this.pos[1] = y;
            this.snakeDir = (int)Dir.right;
        }

        public void printSnake()
        {
            new DrawRect(size, size, pos[0], pos[1], r, g, b).printRect();
            
        }

        public void move()
        {
            if (snakeDir == (int)Dir.right)
            {
                pos[0] += size / 2;
            }
            if (snakeDir == (int)Dir.down)
            {
                pos[1] -= size / 2;
            }
            if (snakeDir == (int)Dir.left)
            {
                pos[0] -= size / 2;
            }
            if (snakeDir == (int)Dir.up)
            {
                pos[1] += size / 2;
            }

        }

        public void setDir()
        {
            if (Keyboard.GetState().IsKeyDown(Key.Right))
            {
                snakeDir = (int)Dir.right;
            }
            if (Keyboard.GetState().IsKeyDown(Key.Down))
            {
                snakeDir = (int)Dir.down;
            }
            if (Keyboard.GetState().IsKeyDown(Key.Left))
            {
                snakeDir = (int)Dir.left;
            }
            if (Keyboard.GetState().IsKeyDown(Key.Up))
            {
                snakeDir = (int)Dir.up;
            }
        }
    }
}
