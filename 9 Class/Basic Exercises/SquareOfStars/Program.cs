using System;
public class Program
{
	public static void Main()
	{
		int n = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 1; i <= n; i++)
        {
            System.Console.Write("*");           
        }
        System.Console.WriteLine("");

            for (int z = 0; z < n; z++)
            {
                System.Console.Write("*");
                for (int c = 0; c < n - 2; c++)
                {
                    System.Console.Write(" ");
                }
                System.Console.WriteLine("*");
                
            }
        for (int j = 1; j <= n; j++)
        {
            System.Console.Write("*");
        }
        
	}
}