using System;
public class Program
{
	public static void Main()
	{
		string password = "random";
        string guessPassword;

        System.Console.Write("Guess the password = ");
        guessPassword = Console.ReadLine().ToLower();

        if (password == guessPassword){
            System.Console.WriteLine("Congrats");
        }
        else {
            System.Console.WriteLine("Failed");
        }
	}
}