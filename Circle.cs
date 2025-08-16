using System;

namespace SOLID
{
    internal interface IShape
    {
    }
    internal interface I3DShape : IShape
    {
        void GetVolume();
    }
    internal interface I2DShape : IShape
    {
        void GetArea();
    }
    internal class Circle : I2DShape
    {
        public double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public void GetArea()
        {
            Console.WriteLine(Math.PI * _radius * _radius);
        }
    }
    internal class Rectangle : I2DShape
    {
        public double _length;
        public double _breadth;

        public Rectangle(double length, double breadth)
        {
            _length = length;
            _breadth = breadth;
        }

        public void GetArea()
        {
            Console.WriteLine(2 * (_length * _breadth));
        }
    }
    internal class Square : I2DShape
    {
        public double _side;

        public Square(double side)
        {
            _side = side;
        }

        public void GetArea()
        {
            Console.WriteLine(_side*_side);
        }
    }
    internal class Cube : I3DShape
    {
        public double _side;

        public Cube(double side)
        {
            _side = side;
        }

        public void GetVolume()
        {
            Console.WriteLine(_side * _side * _side);
        }
    }
}