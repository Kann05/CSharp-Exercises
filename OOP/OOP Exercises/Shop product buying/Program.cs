using System;

class Person
{
    public string Name { get; set; }
    public decimal Balance { get; set; }

    public Person(string name, decimal balance)
    {
        Name = name;
        Balance = balance;
    }

    public void BuyProduct(Product product)
    {
        if (Balance >= product.Price)
        {
            Console.WriteLine($"{Name} bought {product.Name}");
            Balance -= product.Price;
        }
        else
        {
            Console.WriteLine($"{Name} does not have enough balance to buy {product.Name}. Insufficient funds.");
        }
    }
}

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter person's name:");
        string personName = Console.ReadLine();
        Console.WriteLine("Enter person's balance:");
        decimal personBalance = Convert.ToDecimal(Console.ReadLine());

        Person person = new Person(personName, personBalance);

        while (true)
        {
            Console.WriteLine("Enter product name (or 'END' to finish buying):");
            string productName = Console.ReadLine();

            if (productName.Equals("END", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            Console.WriteLine("Enter product price:");
            decimal productPrice = Convert.ToDecimal(Console.ReadLine());

            Product product = new Product(productName, productPrice);
            person.BuyProduct(product);
        }

        Console.WriteLine($"{person.Name} has a balance of {person.Balance} remaining.");
    }
}
