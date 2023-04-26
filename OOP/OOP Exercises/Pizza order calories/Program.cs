using System;

class Pizza
{
    private string stuffing;
    private double stuffingCalories;
    private double toppingCalories;

    // Stuffing constants
    private const double WHITE_STUFFING_CALORIES = 1;
    private const double WHOLEGRAIN_STUFFING_CALORIES = 1.2;
    private const double CRISPY_STUFFING_CALORIES = 0.9;

    // Topping constants
    private const double MEAT_TOPPING_CALORIES = 120;
    private const double VEGGIES_TOPPING_CALORIES = 50;
    private const double CHEESE_TOPPING_CALORIES = 80;
    private const double SAUCE_TOPPING_CALORIES = 40;

    public Pizza(string stuffing)
    {
        this.stuffing = stuffing;
        switch (stuffing.ToLower())
        {
            case "white":
                stuffingCalories = WHITE_STUFFING_CALORIES;
                break;
            case "wholegrain":
                stuffingCalories = WHOLEGRAIN_STUFFING_CALORIES;
                break;
            case "crispy":
                stuffingCalories = CRISPY_STUFFING_CALORIES;
                break;
            default:
                Console.WriteLine("Invalid stuffing selection. Defaulting to white stuffing.");
                stuffingCalories = WHITE_STUFFING_CALORIES;
                break;
        }
        toppingCalories = 0;
    }

    public void AddTopping(string topping)
    {
        switch (topping.ToLower())
        {
            case "meat":
                toppingCalories += MEAT_TOPPING_CALORIES;
                break;
            case "veggies":
                toppingCalories += VEGGIES_TOPPING_CALORIES;
                break;
            case "cheese":
                toppingCalories += CHEESE_TOPPING_CALORIES;
                break;
            case "sauce":
                toppingCalories += SAUCE_TOPPING_CALORIES;
                break;
            default:
                Console.WriteLine($"Invalid topping selection: {topping}");
                break;
        }
    }

    public void CalculateTotalCalories(int grams)
    {
        double totalCalories = (grams / 250.0) * (600 + stuffingCalories + toppingCalories);
        Console.WriteLine($"Total calories: {totalCalories}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Pizza Maker!");
        Console.WriteLine("Choose a stuffing: white, wholegrain, crispy");
        string stuffing = Console.ReadLine();
        Pizza pizza = new Pizza(stuffing);

        while (true)
        {
            Console.WriteLine("Add a topping (meat, veggies, cheese, sauce), or type 'done' to finish");
            string topping = Console.ReadLine();
            if (topping.ToLower() == "done")
                break;
            pizza.AddTopping(topping);
        }

        Console.WriteLine("Enter grams of pizza (default: 250g): ");
        int grams = Convert.ToInt32(Console.ReadLine());
        pizza.CalculateTotalCalories(grams);
    }
}
