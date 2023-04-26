using System;

namespace TimeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            int third = int.Parse(Console.ReadLine());

            int totalSeconds = first + second + third;
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;

            Console.WriteLine("Time: " + minutes + " minutes " + (seconds < 10 ? "0" : "") + seconds + " seconds");
        }
    }
}
