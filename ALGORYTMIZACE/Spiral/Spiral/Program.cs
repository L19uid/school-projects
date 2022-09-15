using System;

namespace Spiral // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte X.");
            string inputX = Console.ReadLine();
            int x = int.Parse(inputX);
            
            Console.WriteLine("Zadejte deltu.");
            string inputDelta = Console.ReadLine();
            int delta = int.Parse(inputDelta);

            Console.Clear();

            Spiral spiral = new Spiral(delta, x);
            spiral.FindEnd();
        }
    }
}