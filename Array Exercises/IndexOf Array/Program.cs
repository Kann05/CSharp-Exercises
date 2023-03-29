using System;
public class Program
{
	public static void Main()
	{
		int[] array = new int[] {-3, -5, 2, 10, 0, 7, 4};
        //Helper int index !!!
        System.Console.Write("Enter the number you want to find the indexof in the array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int index = Array.IndexOf(array, n);

        if (index == -1){
            System.Console.WriteLine("Element not found in the array");
        }
        else {
            System.Console.WriteLine(index);
        }
    }	
}
