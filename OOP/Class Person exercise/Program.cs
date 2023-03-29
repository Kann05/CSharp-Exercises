using System;

namespace Alphabet
{
    class Person{
        public string name;
        public int age;
        public void Introducing(){
            name = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine(name);
            System.Console.WriteLine(age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Introducing();          
        }
    }
}
