using System;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Person person = new Person();

            Console.Write("Enter first name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter age: ");
            string ageInput = Console.ReadLine();
            int age;
            if (int.TryParse(ageInput, out age))
            {
                person.Age = age;

                Console.WriteLine($"Person's Name: {person.FirstName} {person.LastName}");
                Console.WriteLine($"Age: {person.Age}");
            }
            else
            {
                throw new ArgumentException("Invalid age input.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Finally block executed.");
        }

        Console.WriteLine("Program completed.");
    }
}
