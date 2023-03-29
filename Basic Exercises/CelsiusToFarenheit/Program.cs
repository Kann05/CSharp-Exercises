using System;

class Program
{
    static void Main(string[] args)
    {
        double celsius;
        double fahrenheit;

        Console.Write("Enter temperature in Celsius: ");
        celsius = double.Parse(Console.ReadLine());

        fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("Temperature in Fahrenheit: {0}", fahrenheit);
    }
}



