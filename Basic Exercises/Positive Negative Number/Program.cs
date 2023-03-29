using System;

public class PositiveNegative{
    public void GetUserInfo(out int number){
        System.Console.Write("Enter number: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
    public void PositiveOrNegative(int number){
        if (number == 0){
            System.Console.WriteLine("The number is Zero");
        }
        else if (number > 0){
            System.Console.WriteLine("The number is Positive");
        }
        else {
            System.Console.WriteLine("The number is Negative");
        }
    }
    public void Calling(){
        int number;
        GetUserInfo(out number);
        PositiveOrNegative(number);
    }
}
public class Program
{
	public static void Main()
	{
		PositiveNegative call = new PositiveNegative();
        call.Calling();
	}
}