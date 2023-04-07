using System;
public class Program
{
	public static void Main()
	{
		System.Console.Write("Array index creating: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i <= n -1; i++){
            System.Console.Write($"Index {i}: "); 
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        System.Console.WriteLine();
        System.Console.Write("Array numbers ");

        foreach (int show in array){
            System.Console.Write($"{show} ");
        }

        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            max = Math.Max(max, array[i]);
        }
        System.Console.WriteLine();
        Console.WriteLine("Maximum value: " + max);
        
    }
}