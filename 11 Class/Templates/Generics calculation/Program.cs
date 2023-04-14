class Calculation<T>
{
    public bool numberIsHigherThan100(T num1)
    {
        if (num1.Equals(100))
        {
            return true;
        }
        return false;
    }
}
class Program
{
    public static void Main()
    {
        var calculate = new Calculation<int>();
        calculate.numberIsHigherThan100(100);

    }
}