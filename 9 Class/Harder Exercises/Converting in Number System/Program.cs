using System;

namespace NumberSystemConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number system you want to convert from (decimal, binary, octal): ");
            string fromSystem = Console.ReadLine();
            Console.WriteLine("Enter the number system you want to convert to (decimal, binary, octal): ");
            string toSystem = Console.ReadLine();
            Console.WriteLine("Enter the number you want to convert: ");
            string number = Console.ReadLine();

            if (fromSystem == "decimal" && toSystem == "binary")
            {
                int dec = int.Parse(number);
                string binary = Convert.ToString(dec, 2);
                Console.WriteLine("The binary equivalent of " + dec + " is " + binary);
            }
            else if (fromSystem == "decimal" && toSystem == "octal")
            {
                int dec = int.Parse(number);
                string octal = Convert.ToString(dec, 8);
                Console.WriteLine("The octal equivalent of " + dec + " is " + octal);
            }
            else if (fromSystem == "binary" && toSystem == "decimal")
            {
                int binary = Convert.ToInt32(number, 2);
                Console.WriteLine("The decimal equivalent of " + number + " is " + binary);
            }
            else if (fromSystem == "binary" && toSystem == "octal")
            {
                int dec = Convert.ToInt32(number, 2);
                string octal = Convert.ToString(dec, 8);
                Console.WriteLine("The octal equivalent of " + number + " is " + octal);
            }
            else if (fromSystem == "octal" && toSystem == "decimal")
            {
                int octal = Convert.ToInt32(number, 8);
                Console.WriteLine("The decimal equivalent of " + number + " is " + octal);
            }
            else if (fromSystem == "octal" && toSystem == "binary")
            {
                int dec = Convert.ToInt32(number, 8);
                string binary = Convert.ToString(dec, 2);
                Console.WriteLine("The binary equivalent of " + number + " is " + binary);
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }

            Console.ReadLine();
        }
    }
}
