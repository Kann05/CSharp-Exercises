using System;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of people: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Person[] people = new Person[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter details for person {i + 1}:");
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Person person = new Person
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age
            };

            people[i] = person;
        }

        Array.Sort(people, (p1, p2) => string.Compare(p1.FirstName, p2.FirstName));

        Console.WriteLine("\nSorted People:");

        foreach (var person in people)
        {
            Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Age: {person.Age}");
        }
    }
}
