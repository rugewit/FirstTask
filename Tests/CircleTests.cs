using ShapesLibrary;
using Xunit;

namespace Tests;

public class CircleTests
{
    [Fact]
    public void CircleTestArea1()
    {
        var circleArea = ShapeFactory.CreateShape(
            ShapeFactory.ShapeType.Circle, 5).CalculateArea();
        var realArea = 78.53981633974483;
        Assert.Equal(circleArea, realArea, 0.0000001);
    }
    
    [Fact]
    public void CircleTestArea2()
    {
        var circleArea = ShapeFactory.CreateShape(
            ShapeFactory.ShapeType.Circle, 2.5).CalculateArea();
        var realArea = 19.634954084936208;
        Assert.Equal(circleArea, realArea, 0.0000001);
    }
    
    // проверка отрицательности
    [Fact]
    public void CircleTestArgumentsNegative()
    {
        Assert.Throws<ArgumentException>(() =>
            ShapeFactory.CreateShape(ShapeFactory.ShapeType.Circle, -1, 4, 5).CalculateArea());
    }
    
    // проверка неравенства треугольника
    [Fact]
    public void CircleTestArgumentsTrInequality()
    {
        Assert.Throws<ArgumentException>(() =>
            ShapeFactory.CreateShape(ShapeFactory.ShapeType.Circle, 2, 4, 12).CalculateArea());
    }
    
    // проверка количества аргументов
    [Fact]
    public void CircleTestArgumentsArgumentsCount()
    {
        Assert.Throws<ArgumentException>(() =>
            ShapeFactory.CreateShape(ShapeFactory.ShapeType.Circle, 2, 4).CalculateArea());
    }
}