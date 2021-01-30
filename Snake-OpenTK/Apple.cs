using System;

namespace Snake_OpenTK
{
    class Apple
    {
        public int size = new int();
        public float r = new float();
        public float g = new float();
        public float b = new float();
        public int[] pos = new int[2];

        public Apple(int size, float r, float g, float b)
        {
            this.size = size;
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public int grid(int x)
        {
            return x /10 * 10;
        }

        public void newApple(int cliWidth, int cliHeight)
        {
            Random aux = new Random();
            pos[0] = grid(aux.Next(-cliWidth/2 + size/2, cliWidth/2 - size/2 ));
            pos[1] = grid(aux.Next(-cliHeight/2 + size/2 , cliHeight/2 - size/2));

        }

        public void showApple()
        {
           new DrawRect(size, size, pos[0], pos[1], r, g, b).printRect();
        }

    }
}
