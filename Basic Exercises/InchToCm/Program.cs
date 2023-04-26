using System;
public class Program
{
	public static void Main()
	{
        Console.Write("Inches: ");
		double inch = Convert.ToInt32(Console.ReadLine());
        double centimeters = inch * 2.54;

        System.Console.Write($"{centimeters} centimeters");
	}
}