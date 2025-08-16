using System;

namespace ISP.Solution
{
    internal class Printer
    {
        public void Print(IShape shape)
        {
            Console.WriteLine(shape);
        }
    }
}