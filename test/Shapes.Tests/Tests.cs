namespace Shapes.Tests;

public class Tests
{
    [Fact]
    public void CheckCircleArea()
    {
        var radius = 10.0;
        var circle = new Circle(radius);

        Assert.Equal(Math.PI * radius * radius, circle.Area());
    }

    [Fact]
    public void CheckTriangleArea()
    {
        var a = 4.0;
        var b = 5.0;
        var c = 6.0;
        var p = (a + b + c) / 2;
        var triangle = new Triangle(a, b, c);

        Assert.Equal(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), triangle.Area());
    }

    [Fact]
    public void CheckIsRightTriangle_ShouldBeRight()
    {
        var a = 5.0;
        var b = 12.0;
        var c = 13.0;

        var triangle = new Triangle(a, b, c);

        Assert.True(triangle.IsRight);
    }

    [Fact]
    public void CheckIsRightTriangle_ShouldNotBeRight1()
    {
        var a = 5.0;
        var b = 12.0;
        var c = 14.0;

        var triangle = new Triangle(a, b, c);

        Assert.False(triangle.IsRight);
    }

    [Fact]
    public void CheckIsRightTriangle_ShouldNotBeRight2()
    {
        var a = 4.0;
        var b = 4.0;
        var c = 4.0;

        var triangle = new Triangle(a, b, c);

        Assert.False(triangle.IsRight);
    }

    [Fact]
    public void CheckOOPIsWorking1()
    {
        var a = 4.0;
        var b = 5.0;
        var c = 6.0;
        var p = (a + b + c) / 2;
        Shape triangle = new Triangle(a, b, c);

        Assert.Equal(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), triangle.Area());
    }

    [Fact]
    public void CheckOOPIsWorking2()
    {
        var radius = 10.0;
        Shape circle = new Circle(radius);

        Assert.Equal(Math.PI * radius * radius, circle.Area());
    }
}
