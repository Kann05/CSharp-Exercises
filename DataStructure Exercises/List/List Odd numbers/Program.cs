
using System;
public class Program
{
	public static void Main()
	{
		string nums = Console.ReadLine();
        List<string> collectNumbers = nums.Split(' ').ToList();
        List<int> fixedCollectNumbers = new List<int>();

        for (int index = 0; index < collectNumbers.Count; index++) {
        
            fixedCollectNumbers.Add(Convert.ToInt32(collectNumbers[index]));

            if (fixedCollectNumbers[index] % 2 == 0){
                System.Console.Write($"{fixedCollectNumbers[index]}, ");
            }

        }
	}
}