using System;

namespace WordCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1, word2;

            Console.WriteLine("Enter the first word: ");
            word1 = Console.ReadLine().ToLower();

            Console.WriteLine("Enter the second word: ");
            word2 = Console.ReadLine().ToLower();

            if (word1 == word2)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
