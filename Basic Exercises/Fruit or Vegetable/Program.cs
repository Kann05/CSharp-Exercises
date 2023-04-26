using System;

namespace FruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a name: ");
            string input = Console.ReadLine();

            string result = "unknown";

            switch (input)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "grapes":
                    result = "fruit";
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    result = "vegetable";
                    break;
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
