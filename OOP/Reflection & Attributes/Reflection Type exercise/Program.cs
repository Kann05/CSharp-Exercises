using System;
using System.Reflection;

namespace TypeExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type getHero = typeof(Hero);
            object myhero = Activator.CreateInstance(getHero);
            dynamic hero1 = Convert.ChangeType(myhero, getHero);
            Console.WriteLine(hero1.name);
            Console.WriteLine(hero1.health);
            hero1.health -= 30;
            Console.WriteLine(hero1.health);


            Console.WriteLine();
            Console.WriteLine();

            Type student = typeof(Student);

            Console.WriteLine(student.FullName);
            Console.WriteLine(student.Namespace);
            Console.WriteLine(student.IsClass);
            Console.WriteLine(student.IsPublic);

            Console.WriteLine();
            Console.WriteLine();


            FieldInfo[] studentinfo = student.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);


            foreach (var students in studentinfo)
            {
                Console.WriteLine($"Name ------> {students.Name}");
                Console.WriteLine(students.IsStatic);
                Console.WriteLine(students.FieldType);
                Console.WriteLine(students.IsPublic);
                Console.WriteLine(students.IsPrivate);
                Console.WriteLine();
            }

            MethodInfo[] studentMethodInfos = student.GetMethods();

            foreach (var studs in studentMethodInfos)
            {
                Console.WriteLine($"Name ------> {studs.Name}");
                Console.WriteLine(studs.IsStatic);
                Console.WriteLine(studs.ReturnParameter);
                Console.WriteLine(studs.IsPublic);
                Console.WriteLine(studs.IsPrivate);
                Console.WriteLine();
            }

            MethodInfo informationMethod = student.GetMethod("Information", BindingFlags.Public | BindingFlags.Instance);

            object studentObj = Activator.CreateInstance(student);

            informationMethod.Invoke(studentObj, null);


        }
    }

    public class Hero
    {
        public string name = "Hesh";
        public int health = 350;
    }

    public class Student
    {
        public string name;
        private int age = 18;

        public void Information()
        {
            Console.WriteLine("Your name and age");
        }
    }
}
