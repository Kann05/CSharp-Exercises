using System;
public class Program
{
	public static void Main()
	{
		
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= number; i++){
            if (i % 10 == 7){
                System.Console.WriteLine(i);
            }
        }
	}
}