using System;

namespace LSP.Problem
{
    internal class Program
    {
        static void CalculateArea(IShape shape)
        {
            Console.WriteLine(shape.GetArea());
        }
        static void Main(string[] args)
        {
            IShape circle = new Shape(3);
            CalculateArea(circle);
            new Printer().Print(circle);

            IShape rectangle = new Rectangle(3,4);
            CalculateArea(rectangle);
            new Printer().Print(rectangle);
        }
    }
}