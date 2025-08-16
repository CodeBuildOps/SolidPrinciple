namespace DIP.Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            I2DShape circle = new Shape(3);
            new GetArea().CalculateArea(circle);
            new Printer().Print(circle);

            I2DShape rectangle = new Rectangle(3,4);
            new GetArea().CalculateArea(rectangle);
            new Printer().Print(rectangle);

            I2DShape square = new Square(3);
            new GetArea().CalculateArea(square);
            new Printer().Print(square);

            I3DShape cube = new Cube(3);
            new GetVolume().CalculateVolume(cube);
            new Printer().Print(cube);
        }
    }
}