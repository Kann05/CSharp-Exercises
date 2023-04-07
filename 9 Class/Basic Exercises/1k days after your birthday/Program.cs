using System;

namespace BirthdayCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your birthday (dd/mm/yyyy): ");
            string birthdayInput = Console.ReadLine();

            DateTime birthday = DateTime.ParseExact(birthdayInput, "dd/MM/yyyy", null);
            DateTime thousandDaysLater = birthday.AddDays(1000);

            Console.WriteLine("1000 days after your birthday is: " + thousandDaysLater.ToString("dd/MM/yyyy"));
        }
    }
}
