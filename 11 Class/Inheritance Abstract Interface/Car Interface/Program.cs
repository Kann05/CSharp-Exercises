public interface ICar
{
    void Model();
    void Color();
    void Start();
    void Stop();
}

public interface IElectricCar
{
    void Battery();
}

public class Fields
{
    public string model;
    public string color;
    public string start;
    public string stop;
    public double batteryHealth;

}
public class Seat : ICar
{
    Fields field = new Fields();

    public Seat(string Model, string Color, string Start, string Stop)
    {
        field.model = Model;
        field.color = Color;
        field.start = Start;
        field.stop = Stop;
    }
    public void Model()
    {
        System.Console.WriteLine($"Model name {field.model}");
    }

    public void Color()
    {
        System.Console.WriteLine($"Color {field.color}");
    }

    public void Start()
    {
        System.Console.WriteLine($"Start {field.start}");
    }

    public void Stop()
    {
        System.Console.WriteLine($"Stop {field.stop}");
    }
}

public class Tesla : ICar, IElectricCar
{
    Fields field = new Fields();

    public Tesla(string Model, string Color, string Start, string Stop, double BatteryHealth)
    {
        field.model = Model;
        field.color = Color;
        field.start = Start;
        field.stop = Stop;
        field.batteryHealth = BatteryHealth;
    }
    public void Model()
    {
        System.Console.WriteLine($"Model name {field.model}");
    }

    public void Color()
    {
        System.Console.WriteLine($"Color {field.color}");
    }

    public void Start()
    {
        System.Console.WriteLine($"Start {field.start}");
    }

    public void Stop()
    {
        System.Console.WriteLine($"Stop {field.stop}");
    }

    public void Battery()
    {
        System.Console.WriteLine($"Battery health {field.batteryHealth}%");
    }
}
public class Program
{
    public static void Main()
    {
        Seat seat = new Seat("Seat", "Red", "VRMM", "KRR");
        Tesla tesla = new Tesla("Tesla", "White", "no sound", "no sound", 85);

        seat.Model();
        seat.Color();
        seat.Start();
        seat.Stop();
        System.Console.WriteLine("---------------------------");
        tesla.Model();
        tesla.Color();
        tesla.Start();
        tesla.Stop();
        tesla.Battery();

        

    }
}
