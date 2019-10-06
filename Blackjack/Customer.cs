using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Customer : Player
    {
        bool disposed = false;

        private static Customer customer;

        private Customer()
        {
            point = 0;
            playerType = "Customer";
            this.dealedCards = new List<Card>();
            dealedCards.Clear();            
        }
        public static Customer GetCustomer()
        {
            if (customer == null)
                customer = new Customer();
            return customer;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                customer=null;
            }
            disposed = true;
            base.Dispose(disposing);
        }

        ~Customer()
        {
            Dispose(false);
            Console.WriteLine("Customer's destructor\n");
        }
    }
}
