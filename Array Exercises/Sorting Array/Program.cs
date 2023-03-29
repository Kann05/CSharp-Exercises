using System;
public class Program
{
	public static void Main()
	{
		int[] array = new int[] {-3, -5, 2, 10, 0, 7, 4};
        Array.Sort(array);
        System.Console.WriteLine();
        foreach(int i in array){ 
            System.Console.Write($"{i} ");
        }

	}
}