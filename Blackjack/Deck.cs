using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Deck:IDisposable
    {
        bool disposed = false;
        public List<Card> cards;

        //Singleton design pattern used to create just one deck
        private static Deck deck;
        private Deck()
        {
            cards = new List<Card>();
            CreateDeck();
            ShuffleDeck();
        }

        public static Deck GetDeck()
        {
            if (deck == null)
                deck = new Deck();
            return deck;
        }
        //Singleton ends

        private void CreateDeck()
        {
            cards.Clear();

            var CardSuitsList = Enum.GetValues(typeof(Card.CardSuits)).Cast<Card.CardSuits>().ToList();
            var CardValuesList = Enum.GetValues(typeof(Card.CardValues)).Cast<Card.CardValues>().ToList();

            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    Card card = new Card();
                    switch (j)
                    {
                        case 1:
                            card.CardValue = Card.CardValues.Ace;
                            break;
                        case 11:
                            card.CardValue = Card.CardValues.King;
                            break;
                        case 12:
                            card.CardValue = Card.CardValues.Jack;
                            break;
                        case 13:
                            card.CardValue = Card.CardValues.Queen;
                            break;
                        default:
                            card.CardValue = (Card.CardValues)j;
                            break;
                    }                    
                    card.Suit = (Card.CardSuits)i;
                    card.CreateCardImg(j - 1, i - 1);
                    cards.Add(card);
                }
            }

            if (this.cards.Exists(card => card.CardValue == Card.CardValues.Ace))
                Console.WriteLine("Ace value");
        }

        //Function shuffles deck
        public void ShuffleDeck()
        {
            Random r = new Random();
            cards = cards.OrderBy(x => r.Next()).ToList();
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
                cards.Clear();
                deck = null;
            }
            disposed = true;
        }

        ~Deck()
        {
            Dispose(false);
            Console.WriteLine("Deck's destructor\n");
        }
    }
}
