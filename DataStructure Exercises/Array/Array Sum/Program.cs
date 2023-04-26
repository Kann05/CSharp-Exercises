using System;
public class Program
{
	public static void Main()
	{
		int[] array = new int[]{3, 5, 10, 12};
        int summer = 0;

        for(int i = 0; i < array.Length; i++){
            summer += array[i];
        }
        System.Console.WriteLine(summer);
    }
}