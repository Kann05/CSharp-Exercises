using System;
public class Program
{
	public static void Main()
	{
		System.Console.Write("Enter how many numbers to sum: ");
        int count = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        int max = int.MinValue;

        for (int i = 1; i <= count; i++){
            System.Console.Write(i + ".");
            int numbers = Convert.ToInt32(Console.ReadLine());

            sum += numbers;
            max = Math.Max(max, numbers);

        }

        System.Console.WriteLine($"Your total value is : {sum}");
        System.Console.WriteLine($"The maximum number is {max}");
	}
}