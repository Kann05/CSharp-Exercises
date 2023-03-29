using System;
public class Program
{
	public static void Main()
	{
		System.Console.Write("Enter your speed : ");
        double speed = Convert.ToDouble(Console.ReadLine());

        if (speed <= 10){
            System.Console.WriteLine("Slow");
        }
        else if (speed <= 50 ){
            System.Console.WriteLine("Average");
        }
        else if (speed <= 150 ){
            System.Console.WriteLine("Fast");
        }
        else if (speed <= 1000 ){
            System.Console.WriteLine("Ulta Fast");
        }
        else if (speed > 1000 ){
            System.Console.WriteLine("Extremely Fast");
        }
	}
}