using System;
public class Program
{
	public static void Main()
	{
        double number;
		System.Console.Write("Write a number = ");
        number = Convert.ToDouble(Console.ReadLine());

        if (number % 2 == 0){
            System.Console.WriteLine($"{number} is Even");
        }
        else {
            System.Console.WriteLine($"{number} is Odd");
        }
	}
}