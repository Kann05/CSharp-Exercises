public class Animal
{
    public virtual void Eat()
    {
        System.Console.WriteLine("eating");
    }
}

public class Dog : Animal
{
        public  void Bark()
    {
        System.Console.WriteLine("barking");
    }
}

public class Puppy : Dog
{
    public  void Weep()
    {
        System.Console.WriteLine("weeping");
    }
}
public class Program
{
    public static void Main()
    {
        Puppy actions = new Puppy();
        actions.Eat();
        actions.Bark();
        actions.Weep();
    }
}