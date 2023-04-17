public interface IMakeNoice
{
    void MakeNoise();

}

public interface IMakeTrick
{
    void MakeTrick();
}

public abstract class Animal : IMakeNoice, IMakeTrick
{
    public string name;
    public int age;

    public Animal(string Name, int Age)
    {
        name = Name;
        age = Age;
    }

    public virtual void MakeNoise()
    {
        System.Console.WriteLine($"My name is {name}. I am {age} years old.");
    }
    public virtual void MakeTrick()
    {
        System.Console.Write("Look at my trick ");
    }
}

public class Cat : Animal
{
    public Cat(string Name, int Age) : base (Name, Age)
    {
        
    }

    public override void MakeNoise()
    {
        base.MakeNoise();
        System.Console.WriteLine("Meow !");
    }

    public override void MakeTrick()
    {
        System.Console.WriteLine("No trick for you Im too lazy");
    }
}

public class Dog : Animal
{
    public Dog(string Name, int Age) : base(Name, Age)
    {
        
    }

    public override void MakeNoise()
    {
        base.MakeNoise();
        System.Console.WriteLine("WOOF");
    }

    public override void MakeTrick()
    {
        base.MakeTrick();
        System.Console.Write("*Does a flip*");
    }
}
class Program
{
    public static void Main()
    {
        Cat cat = new Cat("Peri", 2);
        cat.MakeNoise();
        cat.MakeTrick();

        System.Console.WriteLine();

        Dog dog = new Dog("Bobi", 3);
        dog.MakeNoise();
        dog.MakeTrick();
    }
}