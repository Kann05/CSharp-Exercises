using System;

public class CashReceipt{

    public void Head(){
        System.Console.WriteLine("CASH RECEIPT");
        System.Console.WriteLine("------------------------------");
    }
    public void Body(){
        System.Console.WriteLine("Charged to____________________");
        System.Console.WriteLine("Received by___________________");
    }
    public void End(){
        System.Console.WriteLine("------------------------------");
        System.Console.WriteLine("© AlpSer");

    }
    public void Call(){
        Head();
        Body();
        End();
    }
}
public class Program
{
	public static void Main()
	{
		CashReceipt receipt = new CashReceipt();
        receipt.Call();
	}
}