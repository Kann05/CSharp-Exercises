using System;
public class Program
{
	public static void Main()
	{
        System.Console.Write("Employee Name: ");
        string employeeName = Console.ReadLine();
        System.Console.Write("Employee Second Name: ");
        string employeeSecondName = Console.ReadLine();
        System.Console.Write("Employee Age: ");
        int employeeAge = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Employee Gender: ");
        string employeeGender = Console.ReadLine();
        System.Console.Write("Employee Personal ID: ");
        int employeePersonalId = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Employee Unique Number: ");
        int employeeUniqueNumber = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine();
        System.Console.WriteLine();
        System.Console.WriteLine($"Employee Name: {employeeName}");
        System.Console.WriteLine($"Employee Second Name: {employeeSecondName}");
        System.Console.WriteLine($"Employee Age: {employeeAge}");
        System.Console.WriteLine($"Employee Gender: {employeeGender}");
        System.Console.WriteLine($"Employee Personal ID: {employeePersonalId}");
        System.Console.WriteLine($"Employee Unique Number: {employeeUniqueNumber}");
	}
}