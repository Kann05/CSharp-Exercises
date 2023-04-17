public class Operations
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b, double c)
    {
        return a + b + c;
    }

    public decimal Add(decimal a, decimal b, decimal c)
    {
        return a + b + c;
    }
}
class Program
{
    public static void Main()
    {
        Operations operation = new Operations();

        System.Console.WriteLine(operation.Add(2, 10));
        System.Console.WriteLine(operation.Add(20d, 12d, 51d));
        System.Console.WriteLine(operation.Add(31m, 21m, 41m));
    }
}