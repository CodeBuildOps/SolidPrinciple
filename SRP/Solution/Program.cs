using System;

namespace SRP.Solution
{
    internal class Program
    {
        static void CalculateArea(Circle circle)
        {
            Console.WriteLine(circle.GetArea());
        }
        static void Main(string[] args)
        {
            Circle circle = new Circle(3);
            CalculateArea(circle);
            new Printer().Print(circle);
        }
    }
}