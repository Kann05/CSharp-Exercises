using System;
using System.Collections.Generic;

public class Car
{
    public string model;
    public Engine Engine;
    public Load Load;

    public List<Tires> tiresInformation = new List<Tires>();

    public Car()
    {
        Engine = new Engine();
        Load = new Load();
    }
}

public class Engine
{
    public double engineSpeed;
    public double enginePower;
    public string stabilityStatus;
}

public class Tires
{
    public double pressure;
    public int age;
}

public class Load
{
    public double loadWeight;
    public string loadType;
}

public class UserInterface
{
    public List<Car> carsInformation = new List<Car>();

    public void Display()
    {
        Console.Write("Enter car numbers: ");
        int carNumbersDataLooping = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Write the data by following the format (Model, flamable or fragile engine, EngineSpeed, EnginePower, Load Weight, Load Type, tire 1 pressure, tire 1 age, tire 2 pressure, tire 2 age, tire 3 pressure, tire 3 age, tire 4 pressure, tire 4 age,)");

        for (int i = 0; i < carNumbersDataLooping; i++)
        {
            Car car = new Car();

            Console.Write($"Car {i + 1} Information: ");
            string input = Console.ReadLine();
            string[] carInformation = input.Split(' ');

            car.model = carInformation[0].Trim();
            car.Engine.stabilityStatus = carInformation[1].Trim();

            car.Engine.engineSpeed = Convert.ToDouble(carInformation[2].Trim());
            car.Engine.enginePower = Convert.ToDouble(carInformation[3].Trim());

            car.Load.loadWeight = Convert.ToDouble(carInformation[4].Trim());
            car.Load.loadType = carInformation[5].Trim();

            car.tiresInformation.Add(new Tires
            {
                pressure = Convert.ToDouble(carInformation[6].Trim()),
                age = Convert.ToInt32(carInformation[7].Trim())
            });
            car.tiresInformation.Add(new Tires
            {
                pressure = Convert.ToDouble(carInformation[8].Trim()),
                age = Convert.ToInt32(carInformation[9].Trim())
            });
            car.tiresInformation.Add(new Tires
            {
                pressure = Convert.ToDouble(carInformation[10].Trim()),
                age = Convert.ToInt32(carInformation[11].Trim())
            });
            car.tiresInformation.Add(new Tires
            {
                pressure = Convert.ToDouble(carInformation[12].Trim()),
                age = Convert.ToInt32(carInformation[13].Trim())
            });

            carsInformation.Add(car);
        }

        Console.WriteLine("Cars List:");

        foreach (Car allCarInformation in carsInformation)
        {
            string getInfoFromList = $"{allCarInformation.model} {allCarInformation.Engine.stabilityStatus} {allCarInformation.Engine.engineSpeed} {allCarInformation.Engine.enginePower} {allCarInformation.Load.loadWeight} {allCarInformation.Load.loadType}";

            foreach (Tires tire in allCarInformation.tiresInformation)
            {
                getInfoFromList += $" {tire.pressure} {tire.age}";
            }

            Console.WriteLine(getInfoFromList);
        }

        Console.WriteLine("Enter to show only fragile or flamable on the List: ");
        string type = Console.ReadLine();

        foreach (Car car in carsInformation)
        {
            if (car.Engine.stabilityStatus == type)
            {
                Console.WriteLine(car.model);
            }
        }
    }
}

class Program
{
    public static void Main()
    {
        UserInterface UI = new UserInterface();
        UI.Display();
    }
}
