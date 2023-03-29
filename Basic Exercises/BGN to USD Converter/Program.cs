using System;

class Program
{
    static void Main(string[] args)
    {
        double bgn;
        double usd;
        double rate = 1.7; // current exchange rate (1 BGN = 0.58 USD)

        Console.Write("Enter amount in BGN: ");
        bgn = double.Parse(Console.ReadLine());

        usd = bgn / rate;

        Console.WriteLine("Amount in USD: {0}", usd);
    }
}
