class Program
{
    public static void Main()
    {
        int[] arrayNumbers = new int[] {2, 10, 4, 5, 6, 2, 12, 45};

        System.Console.Write("Enter number to check in the array: ");
        int checkNumber = Convert.ToInt32(Console.ReadLine());
        bool exists = false;

        foreach(int arraynumber in arrayNumbers)
        {
            if (checkNumber == arraynumber){
                exists = true;
                break;
            }
        }

        if (exists){
                System.Console.WriteLine($"{checkNumber} exists in the array");
            }
            else 
            {
                System.Console.WriteLine($"{checkNumber} does not exists in the array");
            }
    }
}