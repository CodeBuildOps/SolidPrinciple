using System;

namespace SOLID
{
    internal interface IPrinter
    {
        void Print(IShape shape);
    }
    internal class Printer : IPrinter
    {
        public void Print(IShape shape)
        {
            Console.WriteLine(shape);
        }
    }
}
