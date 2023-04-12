using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConsoleApp114.View
{
    public class Display
    {
        public double budget { get; set; }
        public string season { get; set; }
        public string place { get; set; }
        public string facility { get; set; }
        public double paying { get; set; }
 
        public Display()
        {
            this.budget = 0;
            this.season = "";
            this.place = "";
            this.facility = "";
            this.paying = 0;
 
 
            UserInterface();
        }
 
        public void UserInterface()
        {
            Console.Write("Enter your budget: ");
            budget = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the season you want to travel: ");
            season = Console.ReadLine();
        }
 
        public void ShowResult()
        {
            Console.WriteLine(place);
            Console.WriteLine($"{facility} - {paying}");
        }
    }
}