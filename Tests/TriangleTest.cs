using ShapesLibrary;
using Xunit;

namespace Tests;


public class TriangleTest
{
    [Fact]
    public void TriangleTestArea1()
    {
        var triangleArea = ShapeFactory.CreateShape(
            ShapeFactory.ShapeType.Triangle, 5, 6, 7).CalculateArea();
        var realArea = 14.696938456699;
        Assert.Equal(triangleArea, realArea, 0.0000001);
    }
    
    [Fact]
    public void TriangleTestArea2()
    {
        var triangleArea = ShapeFactory.CreateShape(
            ShapeFactory.ShapeType.Triangle, 3, 4, 5).CalculateArea();
        var realArea = 6;
        Assert.Equal(triangleArea, realArea, 0.0000001);
    }
    
    [Fact]
    public void TriangleTestArgumentsNegative()
    {
        // проверка отрицательности
        Assert.Throws<ArgumentException>(() =>
            ShapeFactory.CreateShape(ShapeFactory.ShapeType.Triangle, -1, 4, 5).CalculateArea());
    }
    
    [Fact]
    public void TriangleTestArgumentsTrInequality()
    {
        // проверка неравенства треугольника
        Assert.Throws<ArgumentException>(() =>
            ShapeFactory.CreateShape(ShapeFactory.ShapeType.Triangle, 2, 4, 12).CalculateArea());
    }
    
    [Fact]
    public void TriangleTestArgumentsArgumentsCount()
    {
        // проверка количества аргументов
        Assert.Throws<ArgumentException>(() =>
            ShapeFactory.CreateShape(ShapeFactory.ShapeType.Triangle, 2, 3).CalculateArea());
    }
    
    [Fact]
    public void TriangleTestRightAngled()
    {
        var triangleRightAngled = (Triangle) ShapeFactory.CreateShape(ShapeFactory.ShapeType.Triangle, 
            3, 4, 5);
        Assert.Equal(triangleRightAngled.IsRightAngled(), true);
        
        var triangleNotRightAngled = (Triangle) ShapeFactory.CreateShape(ShapeFactory.ShapeType.Triangle, 
            3, 4, 6);
        Assert.Equal(triangleNotRightAngled.IsRightAngled(), false);
    }
}