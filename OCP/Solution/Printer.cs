using System;

namespace OCP.Solution
{
    internal class Printer
    {
        public void Print(IShape shape)
        {
            Console.WriteLine(shape);
        }
    }
}