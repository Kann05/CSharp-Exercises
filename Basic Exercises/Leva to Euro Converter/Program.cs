using System;
public class Program
{
	public static void Main()
	{
		System.Console.Write("Write the ammount of leva that you want to convert: ");
        double leva = Convert.ToDouble(Console.ReadLine());
        double euro = leva * 0.5112736;
        System.Console.WriteLine($"You have {Math.Round(euro, 2)} Euro");
	}
}