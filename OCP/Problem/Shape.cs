using System;

namespace OCP.Problem
{
    internal class Shape
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
    internal class Rectangle
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
}