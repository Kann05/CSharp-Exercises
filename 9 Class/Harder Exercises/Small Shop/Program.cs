using System;

namespace TownProductPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter town name (Sofia, Plovdiv, Varna): ");
            string town = Console.ReadLine();

            Console.Write("Enter product name (coffee, water, beer, sweets, peanut): ");
            string product = Console.ReadLine();

            double price = 0;

            switch (town)
            {
                case "Sofia":
                    switch (product)
                    {
                        case "coffee":
                            price = 0.50;
                            break;
                        case "water":
                            price = 0.80;
                            break;
                        case "beer":
                            price = 1.20;
                            break;
                        case "sweets":
                            price = 1.45;
                            break;
                        case "peanut":
                            price = 1.60;
                            break;
                        default:
                            Console.WriteLine("Invalid product input. Please enter a valid product name.");
                            break;
                    }
                    break;
                case "Plovdiv":
                    switch (product)
                    {
                        case "coffee":
                            price = 0.40;
                            break;
                        case "water":
                            price = 0.70;
                            break;
                        case "beer":
                            price = 1.15;
                            break;
                        case "sweets":
                            price = 1.30;
                            break;
                        case "peanut":
                            price = 1.50;
                            break;
                        default:
                            Console.WriteLine("Invalid product input. Please enter a valid product name.");
                            break;
                    }
                    break;
                case "Varna":
                    switch (product)
                    {
                        case "coffee":
                            price = 0.45;
                            break;
                        case "water":
                            price = 0.70;
                            break;
                        case "beer":
                            price = 1.10;
                            break;
                        case "sweets":
                            price = 1.35;
                            break;
                        case "peanut":
                            price = 1.55;
                            break;
                        default:
                            Console.WriteLine("Invalid product input. Please enter a valid product name.");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid town input. Please enter a valid town name.");
                    break;
            }

            if (price > 0)
            {
                Console.WriteLine("Price: " + price);
            }

            Console.ReadLine();
        }
    }
}
