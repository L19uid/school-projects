using System;

namespace Spiral // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Spiral spiral = new Spiral(8, 32);
            spiral.FindEnd();
        }
    }
}