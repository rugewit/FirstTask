namespace ShapesLibrary;


public static class ShapeFactory
{
    public enum ShapeType
    {
        Circle,
        Triangle
    }
    
    public static IShape CreateShape(ShapeType shapeType, params double[] parameters)
    {
        switch (shapeType)
        {
            case ShapeType.Circle:
                if (parameters.Length == 1)
                {
                    return new Circle(parameters[0]);
                }
                else
                {
                    throw new ArgumentException("circle has 1 parameter");
                }
                break;
            case ShapeType.Triangle:
                if (parameters.Length == 3)
                {
                    return new Triangle(parameters[0], parameters[1], parameters[2]);
                }
                else
                {
                    throw new ArgumentException("triangle has 3 parameters");
                }
                break;
            default:
                throw new ArgumentException("Invalid shape type or parameters.");
        }
    }
}