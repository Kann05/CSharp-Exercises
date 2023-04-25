class Program
{
    public static void Main()
    {
        System.Console.Write("Enter a number");
        int number = Convert.ToInt32(Console.ReadLine());

        Dictionary<int, string> dictionary = new Dictionary<int, string>();

        if (!dictionary.ContainsKey(number))
        {
            dictionary.Add(number, "first number in");
        }
    }
}