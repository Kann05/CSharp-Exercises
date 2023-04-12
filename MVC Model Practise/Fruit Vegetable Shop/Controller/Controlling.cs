using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp113.Model;
using ConsoleApp113.View;
 
namespace ConsoleApp113.Controller
{
    public class Controlling
    {
        private Display display;
        private Calculation calculation;
 
        public Controlling()
        {
            display = new Display();
            calculation = new Calculation(display.priceVegetables, display.priceFruits);

            display.total = calculation.CalculateTotal();
            display.Show();
 
 
        }
    }
}