using System;
public class Program
{
	public static void Main()
	{
        double r;
        double rarea;
        double rperimeter;
		System.Console.Write("Write r = ");
        r = Convert.ToDouble(Console.ReadLine());

        rarea = Math.PI * r * r;
        rperimeter = 2 * Math.PI * r;

        System.Console.WriteLine($"Circle Area = {Math.Round(rarea, 2)}");
        System.Console.WriteLine($"Circle Perimeter = {Math.Round(rperimeter, 2)}");
        
	}
}