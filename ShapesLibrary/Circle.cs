namespace ShapesLibrary;

public class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        // проверка на не отрицательность радиуса
        if (radius < 0)
        {
            throw new ArgumentException("radius cannot be negative");
        }
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}