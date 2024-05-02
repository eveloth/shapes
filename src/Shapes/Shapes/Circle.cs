namespace Shapes;

public class Circle : Shape
{
    public Circle(double radius) { Radius = radius; }

    public double Radius { get; set; }

    public override double Area() => Math.PI * (Radius * Radius);
}
