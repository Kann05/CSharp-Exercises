using System;

namespace ElevatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of people waiting for the elevator (Elevator Capacity is 8 !): ");
            int waitingPeople = int.Parse(Console.ReadLine());

            int elevatorCapacity = 8;
            int courses = (int)Math.Ceiling(waitingPeople / (double)elevatorCapacity);

            Console.WriteLine("The elevator will make " + courses + " courses to pick up all " + waitingPeople + " people.");
        }
    }
}
