using System;
public class Program
{
	public static void Main()
	{
		string reverse;
        string distinct;
        string replace;
        int index;
        string text;
        string input;
        string replaceItems;

        Console.WriteLine("Enter array numbers with words:");
        input = Console.ReadLine();

        string[] numberInString = input.Split(' ');
        System.Console.WriteLine();
        System.Console.WriteLine("Your Commands that you can use to modificate the array, (Write USE if you want to use them): ");
        System.Console.Write("- Distinct - ");
        distinct = Console.ReadLine().ToLower();
        System.Console.Write("- Reverse - ");
        reverse = Console.ReadLine().ToLower();
        System.Console.Write("- Replace - ");
        replace = Console.ReadLine().ToLower();
        System.Console.Write("Enter with what to replace the last number in the array: ");
        replaceItems = Console.ReadLine();
        System.Console.WriteLine();

        string[] distinctNumbers = numberInString.Distinct().ToArray();
        string[] replacedNumbersNormal = Array.ConvertAll(numberInString, s => s.ToLower().Replace(replaceItems.ToLower(), ""));
        string[] replacedNumbersDistinct = Array.ConvertAll(distinctNumbers, s => s.ToLower().Replace(replaceItems.ToLower(), ""));


        if (distinct == "use" && reverse is null && replace is null)
        {  
            foreach (string i in distinctNumbers){
                System.Console.WriteLine(i, ' ');
            }
        }
        if (reverse == "use" && distinct == "use" && replace is null){
            Array.Reverse(distinctNumbers);
        }
        if (reverse == "use" && distinct is null && replace is null){
            Array.Reverse(numberInString);
        }
        if (replace == "use" && reverse == "use" && distinct == "use"){
            int lastIdx = replacedNumbersDistinct.Length - 1;
            replacedNumbersDistinct[lastIdx] = replaceItems;
            Array.Reverse(replacedNumbersDistinct);
            foreach (string c in replacedNumbersDistinct){
                System.Console.WriteLine(c, 0, 1, ' ');
            }
        }
        if (replace == "use" && reverse == "use" && distinct is null){
            int lastIdx = replacedNumbersNormal.Length - 1;
            replacedNumbersNormal[lastIdx] = replaceItems;
            Array.Reverse(replacedNumbersNormal);
            foreach (string d in replacedNumbersNormal){
                System.Console.WriteLine(d, 0, 1, ' ');
            }
        }   
        if (replace == "use" && distinct is null && reverse is null){
            int lastIdx = replacedNumbersNormal.Length - 1;
            replacedNumbersDistinct[lastIdx] = replaceItems;
            foreach (string n in replacedNumbersNormal){
                System.Console.Write(n, 0, 1, ' ');
            }
        }
        Console.ReadKey();
	}
}