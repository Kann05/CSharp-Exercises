using System;
public class Program
{
	public static void Main()
	{
		System.Console.Write("Write number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine(Math.Abs(number));
	}
}