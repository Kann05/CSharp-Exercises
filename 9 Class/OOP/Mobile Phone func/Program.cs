using System;

namespace TelephoneAndWebsiteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter multiple telephone numbers separated by spaces in a single row:");
            string telephoneNumbersInput = Console.ReadLine();
            string[] telephoneNumbers = telephoneNumbersInput.Split(' ');

            Console.WriteLine("Please enter multiple website links separated by spaces in a single row:");
            string websiteLinksInput = Console.ReadLine();
            string[] websiteLinks = websiteLinksInput.Split(' ');

            Console.WriteLine("Output:");
            for (int i = 0; i < telephoneNumbers.Length; i++)
            {
                Console.WriteLine("Calling... " + telephoneNumbers[i]);
            }

            for (int i = 0; i < websiteLinks.Length; i++)
            {
                Console.WriteLine("Browsing... " + websiteLinks[i]);
            }

            Console.ReadLine();
        }
    }
}
