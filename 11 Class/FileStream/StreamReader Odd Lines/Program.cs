using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            using (StreamReader sr = new StreamReader(@"..\file.txt"))
            {
                string line;
                int count = 1;
                while ((line = sr.ReadLine()) != null)
                {
                    if (count % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    count++;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }
}
