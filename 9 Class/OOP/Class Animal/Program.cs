using System;
public class Animal{
    public string animaltype;
}

public class Dog : Animal
{
    public Dog()
    {
        animaltype = "mammal";
    }
    public void Calling(){
        System.Console.WriteLine(animaltype);
    }
}

public class Snake : Animal
{
    public Snake()
    {
        animaltype = "reptile";
    }
    public void Calling(){
        System.Console.WriteLine(animaltype);
    }
}

public class Cat : Animal
{
    public Cat()
    {
        animaltype = "mammal";
    }
    public void Calling(){
        System.Console.WriteLine(animaltype);
    }
}
public class Program
{
	public static void Main()
	{
		Dog dog = new Dog();
        Snake snake = new Snake();
        Cat cat = new Cat();

        System.Console.Write("Enter dog, snake or cat to see his type: ");
        string animal = Console.ReadLine().ToLower();

        if (animal == "dog"){
            dog.Calling();
        }
        else if (animal == "snake"){
            snake.Calling();
        }
        else if (animal == "cat"){
            cat.Calling();
        }
	}
}