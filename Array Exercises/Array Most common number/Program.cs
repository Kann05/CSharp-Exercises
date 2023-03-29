using System;

namespace MostCommonNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in the array:");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int mostCommonNumber = FindMostCommonNumber(numbers);

            Console.WriteLine("The most common number in the array is: " + mostCommonNumber);
        }

        static int FindMostCommonNumber(int[] numbers)
        {
            int maxCount = 0;
            int mostCommonNumber = 0;
            int count = 0;

            foreach (int number in numbers)
            {
                foreach (int otherNumber in numbers)
                {
                    if (number == otherNumber)
                    {
                        count++;
                    }
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    mostCommonNumber = number;
                }
            }

            return mostCommonNumber;
        }
    }
}
