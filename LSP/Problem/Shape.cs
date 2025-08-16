using System;

namespace LSP.Problem
{
    interface IShape
    {
        double GetArea();
    }
    internal class Shape : IShape
    {
        private double _radius;
        public Shape(double radius)
        {
            _radius = radius;
        }
        public double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
    internal class Rectangle: IShape
    {
        private double _length;
        private double _breadth;
        public Rectangle(double length, double breadth)
        {
            _length = length;
            _breadth = breadth;
        }
        public double GetArea()
        {
            return 2 * (_length + _breadth);
        }
    }
    internal class Square // : Rectangle
    {
        private double _side;

        // This is the problem, asking for initialise length & breadth
        public Square(double side)
        {
            _side = side;
        }
        public double GetArea()
        {
            return _side * _side;
        }
    }
}