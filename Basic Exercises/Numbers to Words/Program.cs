using System;

namespace NumberToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (between 0 and 10): ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 0 && number <= 10)
            {
                string words = ConvertNumberToWords(number);
                Console.WriteLine("Number in words: " + words);
            }
            else
            {
                Console.WriteLine("Number should be between 0 and 10.");
            }
        }

        static string ConvertNumberToWords(int number)
        {
            string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            return words[number];
        }
    }
}
