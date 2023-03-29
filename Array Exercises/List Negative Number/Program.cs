using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a list of positive numbers separated by spaces:");
        string input = Console.ReadLine();
        List<string> inputList = input.Split(' ').ToList();
        List<double> positiveNumbers = new List<double>();

        foreach (string numberString in inputList)
        {
            if (double.TryParse(numberString, out double number))
            {
                if (number >= 0)
                {
                    positiveNumbers.Add(number);
                }
                else
                {
                    Console.WriteLine($"Invalid input: {numberString} is a negative number. Please enter a positive number.");
                }
            }
            else
            {
                Console.WriteLine($"Invalid input: {numberString} is not a valid number.");
            }
        }

        Console.WriteLine($"The list of positive numbers entered is: {string.Join(", ", positiveNumbers)}");
    }
}
