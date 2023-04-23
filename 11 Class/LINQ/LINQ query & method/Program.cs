class Cars
{
    public string model;
    public int year;
}
class Program
{
    static void Main()
    {
        List<Cars> cars = new List<Cars>()
        {
            new Cars {model = "BMW", year = 2001},
            new Cars {model = "Mercedes", year = 2005},
            new Cars {model = "Maserati", year = 2022},
            new Cars {model = "BMW", year = 2001},
            new Cars {model = "BMW", year = 2018}


        };

        //LINQ METHOD

        var methodLINQ = cars.Where(p => p.model == "Mercedes" && p.year == 2005);

        int j = 0;
        foreach(var car in methodLINQ)
        {
            j++;
            System.Console.WriteLine("{0} {1}", car.model, car.year);
        }
        System.Console.WriteLine("Found {0} cars with that exact model and year", j);

        
        System.Console.WriteLine();
        
        //LINQ Query
        var queryLinq = from car in cars
        where car.model == "BMW" &&
        car.year == 2001
        select car;

        int i = 0;
        foreach(var car in queryLinq)
        {
            i++;
            System.Console.WriteLine("{0} {1}", car.model, car.year);
        }

        System.Console.WriteLine("Found {0} cars with that exact model and year", i);

        System.Console.WriteLine();

        //LINQ ordering cars by years
        var yearDesending = cars.OrderByDescending(p => p.year);

        foreach(var orderByDescending in yearDesending)
        {
            System.Console.WriteLine("{0} {1}", orderByDescending.model, orderByDescending.year);
        }

    }
}