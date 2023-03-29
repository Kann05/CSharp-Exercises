using System;
public class Program
{
	public static void Main()
	{
        
		int[] firstArray = new int[] {2, 4, 5};
        int[] secondArray = new int[] {3, 6, 9, 11, 12};

        firstArray.CopyTo(secondArray, 0); //0 shows the index where it starts to copy from firstarray to secondarray
        System.Console.WriteLine(string.Join(" ", secondArray));
        
    }
}