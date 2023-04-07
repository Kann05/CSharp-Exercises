using System;
public class Program
{
	public static void Main()
	{
        int first = 1; 
        int second = 3;
		int[] array = new int[] {2, 4, 5, 1, 10};
        Array.Clear(array,first,second);  //First argument takes which array to Array.Clear /// Second Argument takes the start clearing //third stop

        System.Console.WriteLine(string.Join(" ", array));
        
    }
}