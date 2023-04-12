using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
 
namespace ConsoleApp114.Model
{
    public class Calculating
    {
        private double budget;
        private string season;
        private string place;
        private string facility;
        private double paying;
 
        public double Budget
        {
            get { return budget; }
            set { budget = value; }
        }
        public double Paying
        {
            get { return paying; }
            set { paying = value; }
        }
        public string Season
        {
            get { return season; }
            set { season = value; }
        }
        public string Place
        {
            get { return place; }
            set { place = value; }
        }
        public string Facility
        {
            get { return facility; }
            set { facility = value; }
        }
 
        public Calculating(double budget, string season)
        {
            this.budget = budget;
            this.season = season;
            this.place = "";
            this.facility = "";
            this.paying = 0;
 
        }
 
        public string CalculateWhereToGo()
        {
            if (budget >= 1000)
            {
                place = "Somewhere in Europe";
            }
            if (budget <= 100)
            {
                place = "Somewhere in Bulgaria";
            }
            if (budget > 100 && budget < 1000)
            {
                place = "Somewhere in Balkan";
            }
            return place;
        }
        public string Whereit()
        {
            switch (this.place)
            {
                case "Somewhere in Bulgaria":
                    if (season == "summer")
                    {
                        this.facility = "Camp";  
                    }
                    else
                    {
                        this.facility = "Hotel";
                    }
                    break;
 
                case "Somewhere in Balkan":
                    if (season == "summer")
                    {
                        this.facility = "Camp";
                    }
                    else
                    {
                        this.facility = "Hotel";
                    }
                    break;
                case "Somewhere in Europe":
                    if (season == "summer")
                    {
                        this.facility = "Hotel";
                    }
                    else
                    {
                        this.facility = "Hotel";
                    }
                    break;
            }
            return facility;
        }
        public double CalculatePrice()
        {
            switch (this.place)
            {
                case "Somewhere in Bulgaria":
                    if (season == "summer")
                    {
                        this.facility = "Camp";
                        this.paying = budget * 0.3;
                    }
                    else
                    {
                        this.facility = "Hotel";
                        this.paying = budget * 0.7;
                    }
                    break;
 
                case "Somewhere in Balkan":
                    if (season == "summer")
                    {
                        this.facility = "Camp";
                        this.paying = budget * 0.4;
                    }
                    else
                    {
                        this.facility = "Hotel";
                        this.paying = budget * 0.8;
                    }
                    break;
                case "Somewhere in Europe":
                    if (season == "summer")
                    {
                        this.facility = "Hotel";
                        this.paying = budget * 0.9;
                    }
                    else
                    {
                        this.facility = "Hotel";
                        this.paying = budget * 0.9;
                    }
                    break;
            }
            return paying;
        }
    }
}