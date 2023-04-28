using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Register_to_website_custom_message
{
    public class WebsiteRegisterInfoArgs : EventArgs
    {
        public WebsiteRegisterInfo WebsiteRegisterInfo { get; set; }
    }
    public class WebsiteRegisterInfo
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }

    public class WebsiteRegisterGetMessage
    {
        public event EventHandler<WebsiteRegisterInfoArgs> WebRegister;
        WebsiteRegisterInfo reg = new WebsiteRegisterInfo();
        public void GetUserInput()
        {
            Console.WriteLine("Welcome to our Website, please register to continue !");
            Console.Write("Enter Name: ");
            reg.Name = Console.ReadLine();
            Console.Write("Enter Password: ");
            reg.Password = Console.ReadLine();
        }
        public void RegisterOnWebsite()
        {
            Console.WriteLine("Waiting for system to add your data in the database system...");
            Thread.Sleep(3000);

            OnRegister(new WebsiteRegisterInfoArgs { WebsiteRegisterInfo = reg });


        }

        protected virtual void OnRegister(WebsiteRegisterInfoArgs e)
        {
            WebRegister?.Invoke(this, e);
        }
    }
    public class Registers
    {
        public void Register(object source, WebsiteRegisterInfoArgs e)
        {
            Console.WriteLine("You successfully registered to our website !");
            Console.WriteLine("Save your register information somewhere so you dont forget it ");
            Thread.Sleep(1000);
            Console.WriteLine($"Name: {e.WebsiteRegisterInfo.Name}, Password: {e.WebsiteRegisterInfo.Password}");


        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var reginfo = new WebsiteRegisterGetMessage();
            var registerMessage = new Registers();

            reginfo.WebRegister += registerMessage.Register;

            reginfo.GetUserInput();
            reginfo.RegisterOnWebsite();

            Console.WriteLine();

        }
    }
}
