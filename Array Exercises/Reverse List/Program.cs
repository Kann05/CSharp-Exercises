using System;
public class Program
{
	public static void Main()
	{
		string nums = Console.ReadLine();
        List<string> names = nums.Split(' ').ToList();

        names.Reverse();

        foreach(string i in names){
            System.Console.WriteLine($"{i}; ");
        }
	}
}