using System;
public class Program
{
	public static void Main()
	{
		int[] array = new int[] {5, 10, 2, 1, 5, 7, 6, 1, 6, 8};
        bool numberFind = false;
        int index = -1;
        int count = 0;

        System.Console.Write("Enter number to find in the array: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < array.Length; i++){
                
            if (number == array[i]){
                if (!numberFind){
                    numberFind = true;
                    index = i;
                    count++;
                }
                else{
                    count++;
                }  
            }
        }
        if (numberFind){
            System.Console.WriteLine($"Number found in {index} index, {count} times!");
        }
        else{
            System.Console.WriteLine("Number not found!");
        }

	}
}