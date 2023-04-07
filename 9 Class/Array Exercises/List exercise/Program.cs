using System;
public class Program
{
	public static void Main()
	{
        int index = -1;
        int temp = 0;
        string nums = Console.ReadLine();
        List<string> readNumbers = nums.Split(' ').ToList();
        List<int> readNumbersInt = new List<int>();

        for (int i = 0; i < readNumbers.Count; i++){
            
            readNumbersInt.Add(Convert.ToInt32(readNumbers[i]));
            System.Console.WriteLine($"In Index {i} the value is: {readNumbersInt[i]}");
            
            temp = i;
        }
            index = temp;
            System.Console.WriteLine($"Total Index in List: {index}"); 
	}
}