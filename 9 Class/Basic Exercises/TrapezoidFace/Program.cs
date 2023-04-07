using System;
public class Program
{
	public static void Main()
	{
        double b1;
        double b2;
        double h;
        System.Console.Write("Enter b1 = ");
        b1 = Convert.ToDouble(Console.ReadLine());
        System.Console.Write("Enter b2 = ");
        b2 = Convert.ToDouble(Console.ReadLine());
        System.Console.Write("Enter h = ");
        h = Convert.ToDouble(Console.ReadLine());

        double formula = (b1 + b2) * h / 2;

        System.Console.WriteLine($"Trapezoid Area = {formula}");

	}
}