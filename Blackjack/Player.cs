using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public abstract class Player:IDisposable
    {
        bool disposed = false;

        public List<Card> dealedCards;
        protected int point = 0;
        public string playerType { get; set; }
        public bool IsBlackjack { get => isBlackjack; set => isBlackjack = value; }

        private bool isBlackjack = false;

        public void GetCard()
        {
            this.dealedCards.Add(Deck.GetDeck().cards.First());
            CalculatePoint();

            Deck.GetDeck().cards.Remove(Deck.GetDeck().cards.First());
        }

        public void CalculatePoint()
        {
            this.point = this.dealedCards.Sum(card => (int)card.CardValue);
            if (this.dealedCards.Exists(card => card.CardValue == Card.CardValues.Ace))
            {
                //If player gets an Ace card and total point is greater than 21, Ace value becomes 1
                if (GetPoint() > 21)
                {
                    dealedCards.Find(card => card.CardValue == Card.CardValues.Ace).CardValue = (Card.CardValues)1;
                    CalculatePoint();
                }
            }
            if (this.point == 21)
            {
                IsBlackjack = true;
            }
        }

        public int GetPoint()
        {
            return this.point;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;
            if (disposing)
            {
                dealedCards.Clear();
                point = 0;
                isBlackjack = false;
            }
            disposed = true;
        }

        ~Player()
        {
            Dispose(false);
            Console.WriteLine("Player's destructor\n");
        }
    }
}
