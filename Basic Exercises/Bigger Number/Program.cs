using System;
public class Program
{
	public static void Main()
	{
        double num1;
        double num2;
		System.Console.Write("Enter number 1 = ");
        num1 = Convert.ToDouble(Console.ReadLine());

        System.Console.Write("Enter number 2 = ");
        num2 = Convert.ToDouble(Console.ReadLine());

        double MaxNum = Math.Max(num1, num2);
        double MinNum = Math.Min(num1, num2);

        System.Console.WriteLine($"Biggest Number is {MaxNum}");
        System.Console.WriteLine($"Smallest Number is {MinNum}");
	}
}