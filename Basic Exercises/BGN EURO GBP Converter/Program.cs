using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount;
            string fromCurrency, toCurrency;

            Console.WriteLine("Enter the amount to convert: ");
            amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the currency to convert from (BGN, EUR, GBP): ");
            fromCurrency = Console.ReadLine().ToUpper();

            Console.WriteLine("Enter the currency to convert to (BGN, EUR, GBP): ");
            toCurrency = Console.ReadLine().ToUpper();

            if (fromCurrency == "BGN" && toCurrency == "EUR")
            {
                amount = amount / 1.95583;
            }
            else if (fromCurrency == "BGN" && toCurrency == "GBP")
            {
                amount = amount / 2.19714;
            }
            else if (fromCurrency == "EUR" && toCurrency == "BGN")
            {
                amount = amount * 1.95583;
            }
            else if (fromCurrency == "EUR" && toCurrency == "GBP")
            {
                amount = amount / 1.14342;
            }
            else if (fromCurrency == "GBP" && toCurrency == "BGN")
            {
                amount = amount * 2.19714;
            }
            else if (fromCurrency == "GBP" && toCurrency == "EUR")
            {
                amount = amount * 1.14342;
            }
            else
            {
                Console.WriteLine("Invalid currency entered");
                return;
            }

            Console.WriteLine("Converted amount: " + amount);
        }
    }
}

