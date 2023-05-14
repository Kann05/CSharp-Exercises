using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    [Author("Kann05")]
    public class CalculateSum
    {
        private readonly int a;
        private readonly int b;
        

        public CalculateSum(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Sum()
        {
            int sum = a + b;

            return sum;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var sum = new CalculateSum(2, 10);

            Console.WriteLine(sum.Sum());
        }
    }
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class Author : Attribute
    {
        public Author(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
