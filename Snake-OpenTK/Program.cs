using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Snake_OpenTK
{
    class Program
    {
        
        static void Main(string[] args)
        {
            new Game(300, 300,"Snake").Run(30);
        }
    }        
}


