using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting_exercise1
{
    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            return (user.IsAdmin || MadeBy == user);
        }
    }
    
    public class User
    {
        public bool IsAdmin { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
