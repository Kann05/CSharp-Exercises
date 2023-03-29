using System;
public class Program
{
	public static void Main()
	{
        System.Console.WriteLine("Number Reverse");
		int[] array = new int[] {10, 20, 30, 40, 50,};
         Array.Reverse(array);
         foreach (int arr in array){
           
            System.Console.WriteLine(arr);
        }
        System.Console.WriteLine();
        System.Console.WriteLine("Alphabet Reverse");
        string[] words = new string[26];

        for (int i = 0; i < 26; i++){
            words[i] = ((char)('a' + i)).ToString();
        }

        Array.Reverse(words);

        foreach (string i in words)
        {
            System.Console.Write($"{i} ");
        }
    }
}