namespace ShapesLibrary;

public class Triangle : IShape
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        // проверка на не отрицательность сторон
        if (sideA < 0 || sideB < 0 || sideB < 0)
        {
            throw new ArgumentException("side cannot be negative");
        }
        
        // проверка на выполнение неравенства треугольника
        var sides = new[] { sideA, sideB, sideC };
        Array.Sort(sides);
        // если есть нарушение неравенства треугольника
        // то, можно отсортировать массив и выполнить только 1 проверку:
        // сравнить длину наибольшей стороны с суммой двух наименьших
        if (sides[0] + sides[1] <= sides[2])
        {
            throw new ArgumentException("triangle inequality is broken");
        }
        
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double CalculateArea()
    {
        // вычисления по формуле Герона
        var p = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }

    public bool IsRightAngled()
    {
        // Вычисления по теорема Пифагора
        double[] sides = { SideA, SideB, SideC };
        Array.Sort(sides);
        const double tolerance = 0.000000000001;
        // Для сравнения чисел с плавающей точкой будем использовать tolerance
        return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < tolerance;
    }
}