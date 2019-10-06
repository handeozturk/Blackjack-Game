using Blackjack.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public class Card
    {
        private CardValues cardValue;
        private CardSuits suit;
        private Bitmap img;
        private Bitmap tempImg;
        private CardValues tempValue;
        int height = 153;
        int width = 99;
        public bool isClosed;

        Image im = Blackjack.Properties.Resources.cardDeck;
        Bitmap bitmap;

        public CardValues CardValue { get => cardValue; set => cardValue = value; }
        public CardSuits Suit { get => suit; set => suit = value; }
        public Bitmap Img { get => img; set => img = value; }

        public Card()
        {
            CardValue = 0;
            Suit = 0;
            Img = null;
            isClosed = false;
        }
        public enum CardValues
        {
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10, 
            Jack=10,
            Queen=10,
            King=10,
            Ace = 11
        }

        public enum CardSuits
        {
            Club = 1,
            Diamond,
            Heart,
            Spade            
        }

        public void CreateCardImg(int xCoord, int yCoord)
        {           
            bitmap = new Bitmap(im, width, height);
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawImage(im, new Rectangle(0, 0, width, height), new Rectangle(98 * xCoord, 153 * yCoord, width, height), GraphicsUnit.Pixel);
            g.Dispose();
            Img = bitmap;
        }

        public void CloseCard()
        {
            if (!isClosed)
            {
                isClosed = true;
                tempImg = Img;
                tempValue = CardValue;
                CreateCardImg(2, 4);
                CardValue = 0;
                Console.WriteLine("Card is closed!");
            }
            else
            {
                Console.WriteLine("Card is already closed!");
            }
        }

        public void OpenCard()
        {
            if (isClosed)
            {
                isClosed = false;
                Img = tempImg;
                CardValue = tempValue;                
                Console.WriteLine("Card is opened!");
                Console.WriteLine("Opened card value : " + cardValue);
            }
            else
            {
                Console.WriteLine("Card is already open!");
            }
        }

        public PictureBox CreatePictureBox(int offset)
        {
            PictureBox pb = new PictureBox();
            pb.Width = 103;
            pb.Height = 156;    
            pb.Location = new Point(3 + (offset) * 110, 3);
            pb.Image = this.Img;
            return pb;
        }
    }
}
