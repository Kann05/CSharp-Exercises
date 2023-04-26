using System;
public class Program
{
	public static void Main()
	{
        string month;
        int daysStayed;
        double studioPrice = 0;
        double apartamentPrice = 0;
        int studioDaysStayed;
        int apartamentDaysStayed;

        System.Console.Write("Enter Month: ");
        month = Console.ReadLine().ToLower();
        System.Console.Write("Enter number of nights: ");
        daysStayed = Convert.ToInt32(Console.ReadLine().ToLower());

        if (month == "may" || month == "octomber"){
            studioPrice = 50 * daysStayed;
            apartamentPrice = 65 * daysStayed;
            studioDaysStayed = daysStayed;
            apartamentDaysStayed = daysStayed;
            if (studioDaysStayed <= 7){
                System.Console.WriteLine($"Studio price: {Math.Round(studioPrice, 2)}");
            }
            else if (studioDaysStayed > 7){
                studioPrice = studioPrice * 0.95;
                System.Console.WriteLine($"Studio price: {Math.Round(studioPrice, 2)}");
            }
            else if (studioDaysStayed > 14){
                studioPrice = studioPrice * 0.7;
                System.Console.WriteLine($"Studio price: {Math.Round(studioPrice, 2)}");
            }
            if (apartamentDaysStayed > 14){
                apartamentPrice = apartamentPrice * 0.9;
                System.Console.WriteLine($"Apartament price: {Math.Round(apartamentPrice, 2)}");
            }
            else {
                System.Console.WriteLine($"Apartament price: {Math.Round(apartamentPrice, 2)}");
            }
            
        }
        if (month == "june" || month == "september"){
            studioPrice = 75.20 * daysStayed;
            apartamentPrice = 68.70 * daysStayed;
            studioDaysStayed = daysStayed;
            apartamentDaysStayed = daysStayed;
            if (studioDaysStayed <= 14){
                System.Console.WriteLine($"Studio price: {Math.Round(studioPrice, 2)}");
            }
            else if (studioDaysStayed > 14){
                studioPrice = studioPrice * 0.8;
                System.Console.WriteLine($"Studio price: {Math.Round(studioPrice, 2)}");
            }
            if (apartamentDaysStayed > 14){
                apartamentPrice = apartamentPrice * 0.9;
                System.Console.WriteLine($"Apartament price: {Math.Round(apartamentPrice, 2)}");
            }
            else {
                System.Console.WriteLine($"Apartament price: {Math.Round(apartamentPrice, 2)}");
            }
        }
        if (month == "July" || month == "august"){
            studioPrice = 76 * daysStayed;
            apartamentPrice = 77 * daysStayed;
            studioDaysStayed = daysStayed;
            apartamentDaysStayed = daysStayed;

            System.Console.WriteLine($"Studio price: {Math.Round(studioPrice, 2)}");

            if (studioDaysStayed <= 14){
                System.Console.WriteLine($"Studio price: {Math.Round(studioPrice, 2)}");
            }
            else if (apartamentDaysStayed > 14){
                apartamentPrice = apartamentPrice * 0.9;
                System.Console.WriteLine($"Apartament price: {Math.Round(apartamentPrice, 2)}");
            }
            else {
                System.Console.WriteLine($"Apartament price: {Math.Round(apartamentPrice, 2)}");
            }
        }
	}
}