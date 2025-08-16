using System;

namespace ISP.Solution
{
    interface IShape
    {
    }
    interface I3DShape: IShape
    {
        double GetVolume();
    }
    interface I2DShape: IShape
    {
        double GetArea();
    }
    internal class Shape : I2DShape
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
    internal class Rectangle: I2DShape
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
    internal class Square : I2DShape
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
    internal class Cube : I3DShape
    {
        private double _side;
        public Cube(double side)
        {
            _side = side;
        }
        public double GetVolume()
        {
            return _side * _side * _side;
        }
    }
}