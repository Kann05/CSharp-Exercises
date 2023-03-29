using System;
public class Program
{
	public static void Main()
	{
        int examStartHours;
        int examStartMin;
        int studentHours;
        int studentMin;

		System.Console.Write("Exam start hour: ");
        examStartHours = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Exam start minute: ");
        examStartMin = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Student comes hour: ");
        studentHours = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Studen comes minute: ");
        studentMin = Convert.ToInt32(Console.ReadLine());

        if (examStartHours >= studentHours){
            if (examStartMin >= studentMin){
                System.Console.WriteLine("On time");    
            }
            else if (examStartHours > studentHours){
                if (examStartMin < studentMin){
                    System.Console.WriteLine("On time");  
                }
            }
            else {
                System.Console.WriteLine("Late");
            }
        }
        else {
            System.Console.WriteLine("Late");
        }
        
	}
}