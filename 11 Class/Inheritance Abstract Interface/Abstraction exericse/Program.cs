using System;

public abstract class ColoredFigure
{
    public string color;
    public double size;

    public ColoredFigure()
    {
    }

    public virtual void Show()
    {
        Console.WriteLine($"Color: {color}, Size: {size}");
    }

    public abstract void GetName();
    public abstract void GetArea();
}

public class Triangle : ColoredFigure
{
    public override void Show()
    {
        Console.WriteLine($"Color: {color}, Size: {size}");
    }
    public override void GetName()
    {
        Console.WriteLine("Triangle");
    }

    public override void GetArea()
    {
        double s;
        s = Math.Pow(size, 2) * 1.03 / 4;
        Console.WriteLine($"Area: {s}");
    }
}

public class Square : ColoredFigure
{
    public override void Show()
    {
        Console.WriteLine($"Color: {color}, Size: {size}");
    }
    public override void GetName()
    {
        Console.WriteLine("Square");
    }
    public override void GetArea()
    {
        double s;
        s = Math.Pow(size, 2);
        Console.WriteLine($"Area: {s}");
    }
}

public class Circle : ColoredFigure
{
    public override void Show()
    {
        Console.WriteLine($"Color: {color}, Size: {size}");
    }
    public override void GetName()
    {
        Console.WriteLine("Circle");
    }

    public override void GetArea()
    {
        double s;
        s = Math.PI * Math.Pow(size, 2);
        Console.WriteLine($"Area: {s}");
    }
}

class Program
{
    public static void Main()
    {
        Console.Write("Enter n requests: ");
        int requests = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < requests; i++)
        {
            Console.WriteLine($"Enter object {i + 1} color and size (e.g. 'triangle red 5.0'): ");
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');

            string figureType = inputArray[0];
            string color = inputArray[1];
            double size = Convert.ToDouble(inputArray[2]);

            ColoredFigure figure;

            switch (figureType.ToLower())
            {
                case "triangle":
                    figure = new Triangle();
                    break;
                case "square":
                    figure = new Square();
                    break;
                case "circle":
                    figure = new Circle();
                    break;
                default:
                    Console.WriteLine("Invalid figure type.");
                    continue;
            }

            figure.color = color;
            figure.size = size;
            
            figure.Show();
            figure.GetName();
            figure.GetArea();
        }
    }
}
