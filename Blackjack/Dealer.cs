using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Dealer:Player
    {
        bool disposed = false;

        private static Dealer dealer;

        private Dealer()
        {
            point = 0;
            playerType = "Dealer";
            this.dealedCards = new List<Card>();
            dealedCards.Clear();
        }

        public static Dealer GetDealer()
        {
            if (dealer == null)
                dealer = new Dealer();
            return dealer;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                dealer = null;
            }

            disposed = true;
            base.Dispose(disposing);
        }

        ~Dealer()
        {
            Dispose(false);
            Console.WriteLine("Dealer's destructor\n");
        }
    }
}
