using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Stream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is an example of creating manually txt file in bin and writing in it
            string manuallFileCreating = @"..\streamWriter.txt";

            using (StreamWriter write = new StreamWriter(manuallFileCreating))
            {
                write.Write("Thats how you manually create a txt file and write something in it using StreamWriter");
            }

            //This is an example of auto creating txt file in bin and writing in it

            FileStream autoFileCreating = new FileStream(@"..\autoFileCreating.txt", FileMode.OpenOrCreate);

            using (StreamWriter reader = new StreamWriter(autoFileCreating))
            {
                reader.Write("Thats how you auto create a txt file and write something in it using StreamWriter");
            }
        }
    }
}
