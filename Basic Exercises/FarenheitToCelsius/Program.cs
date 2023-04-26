using System;

class Program
{
    static void Main(string[] args)
    {
        double fahrenheit;
        double celsius;

        Console.Write("Enter temperature in Fahrenheit: ");
        fahrenheit = double.Parse(Console.ReadLine());

        celsius = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine("Temperature in Celsius: {0}", celsius);
    }
}