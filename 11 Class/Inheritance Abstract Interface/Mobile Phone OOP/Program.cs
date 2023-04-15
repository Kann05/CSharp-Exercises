using System;

namespace TelephoneAndWebsiteApp
{
    public interface IAction
    {
        void PerformAction();
    }

    public class TelephoneNumber : IAction
    {
        private string number;

        public TelephoneNumber(string number)
        {
            this.number = number;
        }

        public void PerformAction()
        {
            Console.WriteLine("Calling... " + number);
        }
    }

    public class WebsiteLink : IAction
    {
        private string link;

        public WebsiteLink(string link)
        {
            this.link = link;
        }

        public void PerformAction()
        {
            Console.WriteLine("Browsing... " + link);
        }
    }

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

            foreach (string number in telephoneNumbers)
            {
                TelephoneNumber telephoneNumber = new TelephoneNumber(number);
                telephoneNumber.PerformAction();
            }

            foreach (string link in websiteLinks)
            {
                WebsiteLink websiteLink = new WebsiteLink(link);
                websiteLink.PerformAction();
            }

            Console.ReadLine();
        }
    }
}
