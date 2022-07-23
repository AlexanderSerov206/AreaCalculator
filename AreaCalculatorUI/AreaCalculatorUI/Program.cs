using AreaCalculator;

List<IShape> shapes = new List<IShape>();

shapes.Add(new Circle(15));
shapes.Add(new Square(14.3));
shapes.Add(new Triangle(534, 712, 890));
shapes.Add(new Triangle(546, 728, 910));

foreach (IShape shape in shapes)
{
    Console.WriteLine($"The area of {shape.GetType().Name} is {shape.GetArea()}");
}

foreach (Triangle triangle in shapes.Where(x => x is Triangle))
{
    switch (triangle.IsRightAngeled)
    {
        case true:
            Console.WriteLine("Треугольник прямоугольный");
            break;
        case false:
            Console.WriteLine("Треугольник не прямоугольный");
            break;
    }
}

