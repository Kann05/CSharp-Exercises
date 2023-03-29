using System;

namespace GradeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade;
            System.Console.Write("Write your grade = ");
            grade = Convert.ToDouble(Console.ReadLine());

            if (grade >= 5.50){
                System.Console.WriteLine("Ëxcellent !");
            }
            else{
                System.Console.WriteLine("Not Excellent !");
            }
        }
    }
}
