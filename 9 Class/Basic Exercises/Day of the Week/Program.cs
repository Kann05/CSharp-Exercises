using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Better way to write this exercise 


            System.Console.Write("Write a number between 1-7: ");
            int number = Convert.ToInt32(Console.ReadLine());

            string[] daysofWeek = {"Error", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            string calling =  daysofWeek[number];

            System.Console.WriteLine(calling);

            */
            
            Console.Write("Enter a number between 1-7: ");
            int input = int.Parse(Console.ReadLine());

            string result = "Error";

            switch (input)
            {
                case 1:
                    result = "Monday";
                    break;
                case 2:
                    result = "Tuesday";
                    break;
                case 3:
                    result = "Wednesday";
                    break;
                case 4:
                    result = "Thursday";
                    break;
                case 5:
                    result = "Friday";
                    break;
                case 6:
                    result = "Saturday";
                    break;
                case 7:
                    result = "Sunday";
                    break;
            }

            Console.WriteLine(result);
            Console.ReadLine();

        }
        
    }
}
