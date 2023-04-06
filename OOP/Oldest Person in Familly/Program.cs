public class Person{
    public string name;
    public int age;
}

public class Family{

    Person person = new Person();
    Display display = new Display();
    public List<Person> ListWithPeopleNames = new List<Person>();
   public void GetOldestMember()
    {
        int agemax = int.MinValue;
        string oldestMemberName = "";

        foreach (Person list in ListWithPeopleNames)
        {
            if (list.age > agemax)
            {
                agemax = list.age;
                oldestMemberName = list.name;
            }
        }

        System.Console.WriteLine($"The oldest member is: {oldestMemberName}, age: {agemax}");
    }


    public void CheckListPeople()
    {
        foreach(Person checklist in ListWithPeopleNames){
            System.Console.WriteLine($"Member: {checklist.name}, age: {checklist.age}");
        }
    }
}

public class Display{
    public void UserInterface(){
        
        
        Family family = new Family();

        System.Console.Write("Enter number of people you are gonna write: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++){
            Person person = new Person();
            string input = Console.ReadLine();
            string[] getInformation = input.Split(' ');

            person.name = getInformation[0];
            person.age = Convert.ToInt32(getInformation[1]);

            family.ListWithPeopleNames.Add(person);
        }
        
        family.CheckListPeople();
        family.GetOldestMember();
    }

    

}

public class Program{
     static void Main(string[] args)
        {
            Display display = new Display();

            display.UserInterface();

        }
}