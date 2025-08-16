using System;

namespace ISP.Problem
{
    internal class Printer
    {
        public void Print(IShape shape)
        {
            Console.WriteLine(shape);
        }
    }
}