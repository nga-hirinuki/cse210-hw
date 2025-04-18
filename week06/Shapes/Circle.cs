public class Circle : Shape
{
    private double _radius = 0;

    public double GetRadius()
    {
        return _radius;
    }
    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
      return Math.Round(Math.PI * _radius * _radius, 3);
    }
}