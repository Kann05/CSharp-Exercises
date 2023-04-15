public class ArrayCreator
{
    public static T[] Create<T>(int lenght, T item)
    {
        T[] helpArray = new T[lenght];
        
        for (int i = 0; i < lenght; i++)
        {
            helpArray[i] = item;
        }

        return helpArray;
    }
}

class Program
{
    public static void Main()
    {
        int[] integerArray = ArrayCreator.Create(3, 10);
        string[] stringArray = ArrayCreator.Create(2, "Hello");

        foreach (int intArray in integerArray)
        {
            System.Console.WriteLine(intArray);
        }

        foreach (string stringarray in stringArray)
        {
            System.Console.WriteLine(stringarray);
        }
    }
}