using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizz_Buzz
{
    public class FizzBuzzer
    {
        public static string GetValue(int input)
        {
            if (input % 3 == 0 && input % 5 == 0)
                return "FizzBuzz";
            if (input % 3 == 0)    
                return "Fizz";
            if (input % 5 == 0)
                return "Buzz";

            return input.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(FizzBuzzer.GetValue(i));
            }

            Console.ReadLine();
        }
    }
}
