using ShapesLibrary;

// примеры использования

// создание круга радиусом 5
var circle = ShapeFactory.CreateShape(ShapeFactory.ShapeType.Circle, 5);
// получение площади круга
Console.WriteLine($"circle area is {circle.CalculateArea()}");

// создание треугольника со сторонами 3 4 5
var triangle = ShapeFactory.CreateShape(ShapeFactory.ShapeType.Triangle, 3, 4, 5);
// получение площади круга
Console.WriteLine($"triangle area is {triangle.CalculateArea()}");
// проверка прямоугольности
var isRightAngled = (triangle as Triangle)!.IsRightAngled() ? "right angled" : "not right angled";
Console.WriteLine($"triangle is {isRightAngled}");
