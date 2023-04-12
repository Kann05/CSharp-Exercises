using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trubivbasein.Models;
using trubivbasein.Views;
namespace trubivbasein.Controllers
{
    class PoolController
    {
        private Display display;
        private Pool pool;
 
        public PoolController ()
        {
            display = new Display();
            while (pool is null)
            {
                try
                {
                    display.Input();
                    pool = new Pool(display.V, display.P1, display.P2, display.H);
                }
                catch (Exception e)
                {
                    display.Response = e.Message;
                    display.ShowResponse();
                }
            }
            display.Response = pool.Calculate();
            display.ShowResponse();
        }
    }
}