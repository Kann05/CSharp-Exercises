public abstract class Shape
{
    public abstract double calculatePerimeter();
    public abstract double calculateArea();
}

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public override double calculatePerimeter()
    {
        double perimeter = 2 * (Length + Width);
        Console.WriteLine($"Rectangle perimeter = {perimeter}");
        return perimeter;
    }

    public override double calculateArea()
    {
        double area = Length * Width;
        Console.WriteLine($"Rectangle area = {area}");
        return area;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double calculatePerimeter()
    {
        double perimeter = 2 * Math.PI * Radius;
        Console.WriteLine($"Circle perimeter = {perimeter}");
        return perimeter;
    }

    public override double calculateArea()
    {
        double area = Math.PI * Radius * Radius;
        Console.WriteLine($"Circle area = {area}");
        return area;
    }
}

public class Display
{
    public void UI()
    {
        Rectangle rectangle = new Rectangle();
        Circle circle = new Circle();

        Console.Write("Enter rectangle length: ");
        rectangle.Length = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter rectangle width: ");
        rectangle.Width = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter circle radius: ");
        circle.Radius = Convert.ToDouble(Console.ReadLine());

        rectangle.calculatePerimeter();
        rectangle.calculateArea();
        circle.calculatePerimeter();
        circle.calculateArea();
    }
}

class Program
{
    public static void Main()
    {
        Display display = new Display();
        display.UI();
    }
}
