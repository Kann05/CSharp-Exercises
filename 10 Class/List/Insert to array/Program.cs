class Program
{
    public static void Main()
    {
        System.Console.Write("Enter numbers for the array: ");
        string numbers = Console.ReadLine();
        string[] arraynums = numbers.Split(' ');

        System.Console.Write("Array numbers: ");
        foreach (string arr in arraynums)
        {
            System.Console.Write($"{arr}, ");
        }
        System.Console.WriteLine();
        System.Console.Write("Enter number to insert into array: ");
        string insertnumber = Console.ReadLine();

        int[] insertedArray = Array.ConvertAll(arraynums, int.Parse);

        Array.Resize(ref insertedArray, insertedArray.Length + 1);

        insertedArray[insertedArray.Length - 1] = int.Parse(insertnumber);

        Array.Sort(insertedArray);

        System.Console.Write("Inserted Array numbers: ");
        foreach (int arr in insertedArray)
        {
            System.Console.Write($"{arr}, ");
        }
    }
}
