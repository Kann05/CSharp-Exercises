using System;

namespace WordToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word (between zero and ten): ");
            string word = Console.ReadLine().ToLower();

            string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"};
            int number = Array.IndexOf(words, word);

            if (number != -1)
            {
                Console.WriteLine("Number: " + number);
            }
            else
            {
                Console.WriteLine("Invalid word. Please enter a word between zero and ten.");
            }
        }
    }
}
