using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConsoleApp113.Model
{
    public class Calculation
    {
        private double priceVegetables;
        private double priceFruits;
        private double total;
 
        public double PriceVegetables
        {
            get { return priceVegetables; }   
            set { priceVegetables = value; }  
 
        }
 
        public double PriceFruits
        {
            get { return priceFruits; }
            set { priceFruits = value; }
 
        }
 
        public double Total
        {
            get { return total; }
            set { total = value; }
 
        }
 
        public Calculation(double priceVegetables, double priceFruits)
        {
            this.priceVegetables = priceVegetables;
            this.priceFruits = priceFruits;
            
            
        }
 
        public double CalculateTotal(){
            return (PriceVegetables * 2.03) + (PriceFruits * 4.50);
        }
    }
}