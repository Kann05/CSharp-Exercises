using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace trubivbasein.Models
{
    class Pool
    {
        public int v;
        public int V
        {
            get { return v; }
            set
            {
                if (value > 0 && value < 10001) v = value;
                else throw new Exception("Incorrect v value");
            }
        }
        public int p1;
        public int P1
        {
            get { return p1; }
            set
            {
                if (value > 0 && value < 5001) p1 = value;
                else throw new Exception("Incorrect p1 value");
            }
        }
        public int p2;
        public int P2
        {
            get { return p2; }
            set
            {
                if (value > 0 && value < 5001) p2 = value;
                else throw new Exception("Incorrect p2 value");
            }
        }
        public double h;
        public double H
        {
            get { return h; }
            set
            {
                if (value > 0 && value < 25) h = value;
                else throw new Exception("Incorrect h value");
            }
        }
        public Pool(int v, int p1, int p2, double h)
        {
            V = v;
            P1 = p1;
            P2 = p2;
            H = h;
        }
 
        public string Calculate()
        {
            string result = String.Empty;
            double pipe1 = p1 * h;
            double pipe2 = p2 * h;
            var filled = pipe1 + pipe2;
            if (filled <= v)
            {
                result = $"The pool is {(int)(filled / v * 100)} % full.Pipe1: {(int)(pipe1 / filled * 100)}%. Pipe2: {(int)(pipe2 / filled * 100)}%.";
            }
            else result = $"For {h} hours the pool overflows with {filled - v} liters.";
            return result;
        }
    }
}