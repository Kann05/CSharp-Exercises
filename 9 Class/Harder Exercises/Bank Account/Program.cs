using System;

public class BankAccount
    {
        public int id;
        public double balance;

        public double deposit;
        public double withdraw;
        
        public string info;
        public BankAccount()
        {
            id = 1;
            balance = 15;
        }
        public void Path(){
            System.Console.Write("Enter what do you want to do deposit/withdraw/bankaccount info: ");
            info = Console.ReadLine().ToLower();

            if (info == "deposit"){
                BankDeposit();
            }
            else if (info == "withdraw"){
                BankWithdraw();
            }
            else if (info == "bankaccount info"){
                BankInformation();
            }
        }
        public void BankDeposit(){
            System.Console.Write("Enter deposit amount : ");
            deposit = Convert.ToDouble(Console.ReadLine());

            balance += deposit;

            System.Console.WriteLine($"Your ID : {id}");
            System.Console.WriteLine($"Your Balance : {balance}");
        }
        public void BankWithdraw(){
            System.Console.Write("Enter withdraw amount : ");
            withdraw = Convert.ToDouble(Console.ReadLine());

            if (withdraw > balance){
                System.Console.WriteLine("You cant withdraw more than you have !");
            }
            else {
                
            balance -= withdraw;

            System.Console.WriteLine($"Your ID : {id}");
            System.Console.WriteLine($"Your Balance : {balance}");
            }
        }
        public void BankInformation()
        {
            System.Console.WriteLine($"Your ID : {id}");
            System.Console.WriteLine($"Your Balance : {balance}");
        }

        
    }
public class Program
{
	public static void Main()
	{
		BankAccount bank = new BankAccount();
        
        bank.Path();
	}
}