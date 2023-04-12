using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConsoleApp113.View
{
    public class Display
    {
        public double priceVegetables { get; set; }
        public double priceFruits { get; set; }
        public double total {get; set;}
 
        public Display()
        {
            priceVegetables = 0;
            priceFruits = 0;
            total = 0;
            UserInterface();
 
        }
 
 
        public void UserInterface()
        {
            Console.WriteLine("Vegetables are 2.03 leva kg | fruits are 4.50 leva kg");
            Console.Write("Enter kg vegetables: ");
            priceVegetables = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter kg fruits: ");
            priceFruits = Convert.ToDouble(Console.ReadLine());
        }
 
        public void Show()
        {
            System.Console.WriteLine($"Total will be : {Math.Round(total, 2)}");
        }
    }
}