using System;

namespace TimeAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour, minute;

            Console.Write("Enter the hour: ");
            hour = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the minute: ");
            minute = Convert.ToInt32(Console.ReadLine());

            minute += 15;
            if (minute >= 60)
            {
                hour += 1;
                minute -= 60;
            }
            if (hour >= 24)
            {
                hour -= 24;
            }

            Console.WriteLine("The time after 15 minutes will be: " + hour + ":" + minute);
        }
    }
}
