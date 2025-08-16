namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SRP
            I2DShape circle = new Circle(10);
            new Calculate().CalculateArea(circle);
            new Printer().Print(circle);

            //OCP
            I2DShape rectangle = new Rectangle(10,20);
            new Calculate().CalculateArea(rectangle);
            new Printer().Print(rectangle);

            // LSP
            I2DShape square = new Square(10);
            new Calculate().CalculateArea(square);
            new Printer().Print(square);

            //ISP
            I3DShape cube = new Cube(10);
            new Calculate().CalculateVolume(cube);
            new Printer().Print(cube);
        }
    }
}
