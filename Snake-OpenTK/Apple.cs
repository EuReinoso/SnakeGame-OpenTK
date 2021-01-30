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

        public void printApple(int cliWidth, int cliHeight)
        {
            Random aux = new Random();
            pos[0] = aux.Next(-cliWidth+ size/2,cliWidth - size/2);
            pos[1] = aux.Next(-cliHeight + size/2, cliHeight - size/2);

            new DrawRect(size, size,pos[0] ,pos[1], r, g, b).printRect();

        }

    }
}
