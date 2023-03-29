using System;
using System.Collections.Generic;

public class BankAccount
{
    public int id;
    public double balance;
    public double deposit;
    public double withdraw;
    public string info;
    public static List<int> createdIDs = new List<int>();

    public BankAccount(int id)
    {
        if (createdIDs.Contains(id))
        {
            Console.WriteLine("The ID has already been taken, please choose another one.");
            return;
        }

        createdIDs.Add(id);
        this.id = id;
        balance = 0;
    }

    public void Path()
    {
        Console.Write("Enter what do you want to do deposit/withdraw/bankaccount info: ");
        info = Console.ReadLine().ToLower();

        if (info == "deposit")
        {
            BankDeposit();
        }
        else if (info == "withdraw")
        {
            BankWithdraw();
        }
        else if (info == "bankaccount info")
        {
            BankInformation();
        }
    }

    public void BankDeposit()
    {
        Console.Write("Enter deposit amount : ");
        deposit = Convert.ToDouble(Console.ReadLine());

        balance += deposit;

        Console.WriteLine($"Your ID : {id}");
        Console.WriteLine($"Your Balance : {balance}");
    }

    public void BankWithdraw()
    {
        Console.Write("Enter withdraw amount : ");
        withdraw = Convert.ToDouble(Console.ReadLine());

        if (withdraw > balance)
        {
            Console.WriteLine("You cant withdraw more than you have !");
        }
        else
        {
            balance -= withdraw;

            Console.WriteLine($"Your ID : {id}");
            Console.WriteLine($"Your Balance : {balance}");
        }
    }

    public void BankInformation()
    {
        Console.WriteLine($"Your ID : {id}");
        Console.WriteLine($"Your Balance : {balance}");
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Enter your Bank Account ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        BankAccount bank = new BankAccount(id);
        bank.Path();
    }
}
