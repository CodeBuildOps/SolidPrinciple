using System;

namespace SRP.Problem
{
    internal class Program
    {
        static void Print(Circle circle)
        {
            Console.WriteLine(circle);
        }
        static void CalculateArea(Circle circle)
        {
            Console.WriteLine(Math.PI * circle._radius * circle._radius);
        }
        static void Main(string[] args)
        {
            Circle circle = new Circle(3);
            CalculateArea(circle);
            Print(circle);
        }
    }
}