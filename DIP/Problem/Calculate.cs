using System;

namespace DIP.Problem
{
    interface ICalculate
    {
    }
    interface I2DCalculate : ICalculate
    {
        void CalculateArea(I2DShape shape);
    }
    interface I3DCalculate : ICalculate
    {
        void CalculateVolume(I3DShape shape);
    }
    internal class GetArea : I2DCalculate
    {
        public void CalculateArea(I2DShape shape)
        {
            Console.WriteLine(shape.GetArea());
        }
    }
    internal class GetVolume : I3DCalculate
    {
        public void CalculateVolume(I3DShape shape)
        {
            Console.WriteLine(shape.GetVolume());
        }
    }
}