using System;

class Program
{
    static void Main(string[] args)
    {
        double usd;
        double bgn;
        double rate = 1.7; // current exchange rate (1 USD = 1.7 BGN)

        Console.Write("Enter amount in USD: ");
        usd = double.Parse(Console.ReadLine());

        bgn = usd * rate;

        Console.WriteLine("Amount in BGN: {0}", bgn);
    }
}
