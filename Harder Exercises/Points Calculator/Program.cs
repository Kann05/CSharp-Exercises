using System;

namespace PointsCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your points: ");
            double points = int.Parse(Console.ReadLine());

            if (points > 100)
            {
                points += 5;
            }

            if (points > 101)
            {
                points += points * 0.2;
            }

            if (points > 1000)
            {
                points += points * 0.1;
            }

            if (points % 2 == 0)
            {
                points += 1;
            }

            if (points % 10 == 5)
            {
                points += 2;
            }

            Console.WriteLine("Your total points are: " + points);
        }
    }
}
