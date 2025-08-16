using System;

namespace ISP.Problem
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
    internal class Square : IShape
    {
        private double _side;
        public Square(double side)
        {
            _side = side;
        }
        public double GetArea()
        {
            return _side * _side;
        }
    }
    internal class Cube : IShape
    {
        private double _side;
        public Cube(double side)
        {
            _side = side;
        }

        // This is the problem, forced to implements IShape method
        public double GetArea()
        {
            throw new NotImplementedException();
        }
        public double GetVolume()
        {
            return _side * _side * _side;
        }
    }
}