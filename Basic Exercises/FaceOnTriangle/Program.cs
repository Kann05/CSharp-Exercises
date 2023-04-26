using System;
public class Program
{
	public static void Main()
	{
        double a;
        double h;
        System.Console.Write("a = ");
        a = Convert.ToDouble(Console.ReadLine());
        System.Console.Write("h = ");
        h = Convert.ToDouble(Console.ReadLine());

        double solution = a * h /2;
		System.Console.WriteLine($"Triangle Area = {solution}");

	}
}