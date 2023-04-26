class Person
{
    public string FirstName
    {
        get
        {
            return FirstName;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Name cannot be NULL !!!");
            }

            
        }
    }

    public string LastName
    {
        get
        {
            return LastName;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("last name cannot be NULL !!!");
            }
            
        }
    }

    public int Age
    {
        get
        {
            return Age;
        }
        set
        {
            if (int.IsNegative(value))
            {
                throw new ArgumentException("Age cannot be NEGATIVE !!!");
            }

            if (value >= 120)
            {
                throw new ArgumentOutOfRangeException("Age cannot be equal or more than 120 !!!");
            }

            
        }
    }
}
class Program
{
    public static void Main()
    {
        Person person = new Person();

        System.Console.Write("Enter Name: ");
        person.FirstName = Console.ReadLine();
        System.Console.Write("Enter Last Name: ");
        person.LastName = Console.ReadLine();
        System.Console.Write("Enter Age: ");
        person.Age = Convert.ToInt32(Console.ReadLine());
    }
}