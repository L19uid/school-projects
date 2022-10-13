using System;

namespace Field // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Field field = new Field();
            
            Console.WriteLine("FILLARRAY");
            field.FillArray(10);
            Console.WriteLine("ADD");
            field.AddValue(5,9);
            Console.WriteLine("REMOVE");
            field.RemoveValue(2);
            
            Console.WriteLine("DIVIDE");
            field.Divide();
            
            Console.WriteLine("JOIN");
            int[] a = {2};
            int[] b = {5,2,3,5,2,3};

            field.Join(a, b);
        }
    }
}