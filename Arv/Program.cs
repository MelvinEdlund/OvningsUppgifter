
using System.Reflection;
using System.Xml.Schema;
Random rnd = new();

//Uppgift 1
Console.WriteLine("Uppgift 1");
var myVehicle = new Vehicle(Brand.Volvo, Color.White);
Console.WriteLine(myVehicle);

//Uppgift 2
Console.WriteLine("\nUppgift 2");
Console.WriteLine(new Vehicle(Brand.Toyota, Color.White));

//Uppgift 3
Console.WriteLine("\nUppgift 3");
Console.WriteLine(new Car(Brand.Toyota, "Yaris", Color.White));

//Uppgift 4
Console.WriteLine("\nUppgift 4");
var s = new Size(1.2, 3.4, 5.6);
Console.WriteLine($"Längd: {s.Length}, Bredd: {s.Width}, Höjd: {s.Height}");

//Uppgift 5
Console.WriteLine("\nUppgift 5");
Console.WriteLine(new Car(Brand.Toyota, "Yaris", Color.White));
Console.WriteLine(new Car(Brand.Volvo, "XC60", Color.Red));
Console.WriteLine(new Car(Brand.BMW, "i3", Color.Blue));

//Uppgift 6
Console.WriteLine("\nUppgift 6");
var circle1 = new Circle(5);
Console.WriteLine(circle1);
Console.WriteLine($"Area: {circle1.Area:f2}");
Console.WriteLine($"Circumference: {circle1.Circumference:f2}");

//Uppgift 7
Console.WriteLine("\nUppgift 7");
var square1 = new Square(5);
Console.WriteLine(square1);
Console.WriteLine($"Area: {square1.Area:f2}");
Console.WriteLine($"Circumference: {square1.Circumference:f2}");

//Uppgift 8
Console.WriteLine("\nUppgift 8");
var square2 = new Square(3.2);
square2.Print();
var circle2 = new Circle(4.5);
circle2.Print();

//Uppgift 9
Console.WriteLine("\nUppgift 9");
Shape[] shapes = new Shape[10];
ConsoleColor[] colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));

for (int i = 0; i < shapes.Length; i++)
{
    ConsoleColor randomColor = colors[rnd.Next(colors.Length)];

    if (rnd.Next(2) == 0)
    {
        double radius = rnd.NextDouble() * 10;
        shapes[i] = new Circle(radius, randomColor);
    }
    else
    {
        double side = rnd.NextDouble() * 10;
        shapes[i] = new Square(side, randomColor);
    }
}

//Uppgift 10
Console.WriteLine($"\nUppgift 10");
Shape.PrintAll(shapes);
Console.WriteLine();
Shape.PrintCircles(shapes);

class Vehicle //Uppgift 1
{
    Random rnd = new();
    public Brand Brand { get; set; }
    public Color Color { get; set; }
    public Vehicle(Brand brand)
    {
        Brand = brand;
        Color = Color.Black;
        Size = new Size(
            rnd.NextDouble() * (5.0 - 3.5) + 3.5,
            rnd.NextDouble() * (2.0 - 1.5) + 1.5,
            rnd.NextDouble() * (1.8 - 1.3) + 1.3
        );
    }
    public Vehicle(Brand brand, Color color)
    {
        Brand = brand;
        Color = color;
        Size = new Size(
            rnd.NextDouble() * (5.0 - 3.5) + 3.5,
            rnd.NextDouble() * (2.0 - 1.5) + 1.5,
            rnd.NextDouble() * (1.8 - 1.3) + 1.3
        );
    }
// Uppgift 2
    public override string ToString()
    {
        return $"A {Color.ToString()} {Brand}";
    }

    public Size Size { get; set; }
}
enum Brand { Volvo, BMW, Toyota, Saab, Audi }
enum Color { Black, White, Blue, Red, Green }

class Car : Vehicle //Uppgift 3
{
    public string Model { get; set; }
    public Car(Brand brand, string model, Color color) : base (brand, color)
    {
        Model = model;
    }
    public override string ToString()
    {
        return $"A {Color.ToString().ToLower()} {Size.Length:F1} meter long {Model} from {Brand}";
    }
}

//Uppgift 4
struct Size
{
    public double Length { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }

    public Size(double length, double  width, double height)
    {
        Length = length;
        Width = width;
        Height = height;
    }

}

//Uppgift 6
public abstract class Shape
{
    protected ConsoleColor color;
    public abstract double Area { get; }
    public abstract double Circumference { get; }

    //Uppgift 8
    public void Print()
    {
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = color;
        Console.WriteLine($"{this} has an area of {Area:f2} and a circumference of {Circumference:f2}.");
        Console.ForegroundColor = previousColor;
    }

    public static void PrintAll(Shape[] shapes)
    {
        foreach (var shape in shapes)
        {
            shape.Print();
        }
    }

    public static void PrintCircles(Shape[] shapes)
    {
        foreach (var shape in shapes)
        {
            if (shape is Circle)
                shape.Print();
        }
    }
}

class Circle : Shape
{
    public double Radius { get; set; }
   
    public Circle(double radius) => Radius = radius;

    public Circle(double radius, ConsoleColor color) : this(radius)
    {
        this.color = color; // Sätter färgen
    }


    public override double Area => Math.PI * Radius * Radius;

    public override double Circumference => 2 * Math.PI * Radius;
    public override string ToString()
    {
        return $"A circle with radius {Radius:f2}";
    }
}

//Uppgift 7
class Square : Shape
{
    public double Side { get; set; }

    public Square(double side)
    {
        Side = side;
    }
    public Square(double side, ConsoleColor color) : this(side)
    {
        this.color = color;
    }

    public override double Area => Side * Side;
    public override double Circumference => 4 * Side;

    public override string ToString()
    {
        return $"A square with side {Side:f2}";
    }
}