using System;

namespace DIP.Problem
{
    internal class Printer
    {
        public void Print(IShape shape)
        {
            Console.WriteLine(shape);
        }
    }
}