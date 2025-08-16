using System;

namespace OCP.Problem
{
    internal class Program
    {
        static void CalculateArea(Shape circle)
        {
            Console.WriteLine(circle.GetArea());
        }
        static void Main(string[] args)
        {
            Shape circle = new Shape(3);
            CalculateArea(circle);
            new Printer().Print(circle);

            Rectangle rectangle = new Rectangle(3,4);
            // This is the problem
            //CalculateArea(rectangle);
            //new Printer().Print(rectangle);
        }
    }
}