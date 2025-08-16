namespace SOLID
{
    internal class Calculate
    {
        public void CalculateArea(I2DShape shape)
        {
            shape.GetArea();
        }
        public void CalculateVolume(I3DShape shape)
        {
            shape.GetVolume();
        }
    }
}
