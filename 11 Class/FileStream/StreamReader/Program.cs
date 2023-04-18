using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Stream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"..\streamReader.txt";

            using (StreamReader read = new StreamReader(fileName))
            {
                Console.WriteLine(read.ReadLine());
            }
        }
    }
}
