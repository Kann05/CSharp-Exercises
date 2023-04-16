class List
{
    public static List<T> MethodList<T>(T string1, T string2, T helpString, string byOrder)
    {
        List<T> listNames = new List<T>(); 
        listNames.Add(string1);
        listNames.Add(string2);

        //listNames.Reverse();
 
        if (byOrder == "reverse")
        {
            T temp = listNames[0];
            listNames[0] = listNames[1];
            listNames[1] = temp;

            return listNames;
        }
        else {
            return listNames;
        }
    }
}

class Program
{
    static void Main()
    {
        System.Console.WriteLine("Enter 2 names");

        string name1 = Console.ReadLine();
        string name2 = Console.ReadLine();
        System.Console.WriteLine("If you want them to be in the order you wrote them write (nothing), if you want to reverse the order write (reverse)");
        string byOrder = Console.ReadLine();

        List<string> resultList = List.MethodList(name1, name2, "", byOrder);

        foreach (string result in resultList)
        {
            System.Console.WriteLine(result);
        }

    }
}
