public class Nullable<T> where T : struct
{
    private object _value;
    public Nullable()
    {
        
    }
    public Nullable(T value)
    {
     _value = value;    
    }
    public bool HasValue
    {
        get { return _value != null;}
    }

    public T GetValueOrDefault()
    {
        if (HasValue)
        {
            return (T)_value;
        }
        
        return default(T);
    }


}
class Program
{
    public static void Main()
    {
        var check = new Nullable<int>(5);
        System.Console.WriteLine("Has Value ? " + check.HasValue);
    }
}