using System;
public class Program
{
	public static void Main()
	{
		int[] array = new int[] {5, 1, 4, 10, 3, 2, 7, 0, 6};
        int[] distinctArray = array.Distinct().ToArray();
        int temp;

        for (int i = 0; i < array.Length; i++){
            for (int j = 0; j < array.Length -1; j++){
                
                if (array[j] > array[j + 1]){
                    temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }

        foreach (int arr in array){
            System.Console.Write(arr);
        }
	}
}