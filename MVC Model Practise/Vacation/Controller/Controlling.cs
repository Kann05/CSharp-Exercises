using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp114.Model;
using ConsoleApp114.View;
 
namespace ConsoleApp114.Controller
{
    public class Controlling
    {
        private Display display;
        private Calculating calculate;
 
        public Controlling()
        {
            display = new Display();
            calculate = new Calculating(display.budget, display.season);
            display.place = calculate.CalculateWhereToGo();
            display.facility = calculate.Whereit();
            display.paying = calculate.CalculatePrice();
 
            display.ShowResult();
        }
    }
}