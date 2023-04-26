using System;
public class Program
{
	public static void Main()
	{
		System.Console.Write("Enter how many numbers to sum: ");
        int count = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i <= count; i++){
            System.Console.Write(i + ".");
            int numbers = Convert.ToInt32(Console.ReadLine());

            sum += numbers;

        }

        System.Console.WriteLine($"Your total value is : {sum}");
	}
}