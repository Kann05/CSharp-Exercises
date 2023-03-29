using System;


public class Program
{
	public static void Main()
	{
        Calling call = new Calling();

        call.CallingMethod(); 
	}
}
public class Calling
{
    public double lenght;
    public string time;

    public void CallingMethod()
{
    Taxi taxi = new Taxi();
    Bus bus = new Bus();
    Train train = new Train();

    System.Console.Write("Write how many kilometers you are gonna travel: ");
    lenght = Convert.ToDouble(Console.ReadLine());

    System.Console.Write("Write when you are gonna travel day/night: ");
    time = Console.ReadLine();

    if (lenght <= 20){
        
        if (time == "day"){

            System.Console.WriteLine("For this lenght you can travel with (Taxi,Bus and Train), first gonna show you taxi prices");
            System.Console.WriteLine();
            taxi.TaxiDrivingDay(lenght);
            bus.BusDriving(lenght);
            train.TrainDriving(lenght);
            
        }
        else if (time == "night")
        {
            System.Console.WriteLine("For this lenght you can travel with (Taxi,Bus and Train), first gonna show you taxi prices");
            System.Console.WriteLine();
            taxi.TaxiDrivingNight(lenght);
            bus.BusDriving(lenght);
            train.TrainDriving(lenght);
           
        }         
        }
        else if (lenght <= 100)
        {
            if (time == "day")
            {
                System.Console.WriteLine();
                System.Console.WriteLine("For this lenght you can travel with (Taxi & Train), first gonna show you taxi prices");
                System.Console.WriteLine();
                taxi.TaxiDrivingDay(lenght);
                train.TrainDriving(lenght);

               
            }
            else if (time == "night")
            {
                System.Console.WriteLine();
                System.Console.WriteLine("For this lenght you can travel with (Taxi & Train), first gonna show you taxi prices");
                System.Console.WriteLine();
                taxi.TaxiDrivingNight(lenght);
                train.TrainDriving(lenght);
            }
            

        }
        else if (lenght > 100){
            
            if (time == "day")
            {
                System.Console.WriteLine();
                System.Console.WriteLine("For this lenght you can travel with ONLY TAXI");
                System.Console.WriteLine();
                taxi.TaxiDrivingDay(lenght);
                
            }
            else if (time == "night")
            {
                System.Console.WriteLine();
                System.Console.WriteLine("For this lenght you can travel with ONLY TAXI");
                System.Console.WriteLine();
                taxi.TaxiDrivingNight(lenght);
            }
        }

        
    }
}
public class Taxi : Calling
{
    public double startprice = 0.70;
    public double dayprice = 0.79;
    public double nightprice = 0.90;

    public void TaxiDrivingDay(double lenght){
        System.Console.WriteLine($"Taxi Starting price : {startprice} leva");
        System.Console.WriteLine($"Final Price : {startprice + (dayprice * lenght)} leva");
    }

    public void TaxiDrivingNight(double lenght){
        System.Console.WriteLine($"Taxi Starting price : {startprice} leva");
        System.Console.WriteLine($"Final Price : {startprice + (nightprice * lenght)} leva");
    }
}

public class Bus : Calling //20 km max
{
    public double price = 0.09;

    public void BusDriving(double lenght){
        System.Console.WriteLine($"Bus Starting price : 0.00 leva");
        System.Console.WriteLine($"Final Price : {price * lenght} leva");
    }
}

public class Train : Calling //100km max
{
    public double price = 0.06;

    public void TrainDriving(double lenght){
        System.Console.WriteLine($"Train Starting price : 0.00 leva");
        System.Console.WriteLine($"Final Price : {price * lenght} leva");
    }
}