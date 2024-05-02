namespace Shapes;

public class Triangle : Shape
{
    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }
    public bool IsRight => (A * A == (B * B) + (C * C)) ||
                           (B * B == (A * A) + (C * C)) ||
                           (C * C == (A * A) + (B * B));

    public override double Area()
    {
        var p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
}
