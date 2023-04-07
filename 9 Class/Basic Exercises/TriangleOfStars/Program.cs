using System;
public class Program
{
	public static void Main()
	{
        int a = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i <= a; i++)
        {
            for (int j = 0; j < i; j++)
            {
                System.Console.Write("*");

            }
            System.Console.WriteLine();
        }
               
	}
}