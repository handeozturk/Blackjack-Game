using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class BlackJack : Form
    {
        Deck deck;
        Dealer dealer;
        Customer customer;

        public BlackJack()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame()
        {
            lblMsg.Text = "";
            btnHit.Enabled = true;
            btnStand.Enabled = true;
            lblCustomerPt.Visible = true;
            lblDealerPt.Visible = true;

            btnHit.BackColor = Color.LimeGreen;
            btnStand.BackColor = Color.LimeGreen;

            deck = Deck.GetDeck();
            dealer = Dealer.GetDealer();
            customer = Customer.GetCustomer();

            for (int i = 0; i < 2; i++) //Two cards must be dealed in the beginning
            {
                DealCards(i, deck, dealer);
                DealCards(i, deck, customer);
            }

            ControlForCustomer();   //Check if customer is blackjack
        }

        private void DealCards(int iter, Deck deck, Player player)
        {
            if (player.playerType == "Dealer" && iter == 1)     //Second card of dealer must be closed in the begining
                deck.cards.First().CloseCard();
            player.GetCard();
            AddPictureBox(player.dealedCards.Count, player);    //Add dealed card in picture box
        }

        public void AddPictureBox(int cardsCount, Player player)    //Picture boxes holds image of cards
        {
            if (player.playerType == "Dealer")
            {
                pnlCardsDealer.Controls.Add(player.dealedCards.ElementAt(cardsCount - 1).CreatePictureBox(cardsCount - 1));
            }

            else if (player.playerType == "Customer")
            {
                pnlCardsPlayer.Controls.Add(player.dealedCards.ElementAt(cardsCount - 1).CreatePictureBox(cardsCount - 1));
            }

            else
            {
                Console.WriteLine("Undefined player detected in AddPictureBox()!");
                return;
            }
            ShowScores();  
        }

        private void GetCardForPlayer(Player player)    
        {
            player.GetCard();
            AddPictureBox(player.dealedCards.Count, player);
        }

        private void ShowScores()   
        {
            lblCustomerPt.Text = customer.GetPoint().ToString();
            lblDealerPt.Text = dealer.GetPoint().ToString();
        }

        private void ShowDealersCard()  //Shows dealer's second closed card
        {
            dealer.dealedCards.ElementAt(1).OpenCard();
            pnlCardsDealer.Controls.RemoveAt(1);
            dealer.CalculatePoint();
            lblDealerPt.Text = dealer.GetPoint().ToString();
            pnlCardsDealer.Controls.Add(dealer.dealedCards.ElementAt(1).CreatePictureBox(1));
        }

        private void btnHit_Click(object sender, EventArgs e)   //When hit button clicked , gets a card for player
        {
            GetCardForPlayer(customer);
            ControlForCustomer();
        }

        private void btnStand_Click(object sender, EventArgs e) //When stand button clicked , dealer starts to play and customer cannot play
        {
            DisableButtons();
            ShowDealersCard();
            ControlForDealer();
        }

        void ControlForCustomer()   //Controls for all possible situations for customer
        {
            //If customer's point is equal to 21, customer wins
            if (customer.IsBlackjack)   
            {
                ShowDealersCard();
                Console.WriteLine("Blackjack! You win!");
                lblMsg.Text = "Blackjack!\nYou win!";
                DisableButtons();
            }

            //If dealer's point is greater than 21, dealer wins
            else if (customer.GetPoint() > 21) 
            {
                ShowDealersCard();
                Console.WriteLine("Dealer wins!");
                lblMsg.Text = "Dealer wins!";
                DisableButtons();
            }

            //If customer's point is less than 21, customer should decide to hit (get a card) or stand
            else //customer.GetPoint() < 21
            {
                Console.WriteLine("Hit or Stand?");
                lblMsg.Text = "Hit or Stand?";
            }
        }

        void ControlForDealer() //Controls for all possible situations for dealer
        {
            //While dealer' point less than 21 and also less customer's point, dealer should get a card
            while (dealer.GetPoint() < 21 && dealer.GetPoint() < customer.GetPoint())   
            {
                GetCardForPlayer(dealer);
                Console.WriteLine("while loop");
            }

            //If dealer's point is equal to 21, dealer wins
            if (dealer.IsBlackjack)     
            {
                Console.WriteLine("Blackjack!\nDealer wins!");
                lblMsg.Text = "Blackjack!\nDealer wins!";
                DisableButtons();
            }

            //If dealer's point is less than 21 and greater than customer, dealer wins
            else if (dealer.GetPoint() < 21 && dealer.GetPoint() > customer.GetPoint()) 
            {
                Console.WriteLine("Dealer wins!");
                lblMsg.Text = "Dealer wins!";
                DisableButtons();
            }

            //If dealer's point is greater than 21, customer wins
            else if (dealer.GetPoint() > 21)
            {
                Console.WriteLine("You win!");
                lblMsg.Text = "You win!";
                DisableButtons();
            }

            //If dealer's point is equal to customer's point, it's tie
            else if (dealer.GetPoint() == customer.GetPoint())
            {
                Console.WriteLine("Tie!");
                lblMsg.Text = "Tie!";
            }
            lblDealerPt.Text = dealer.GetPoint().ToString();
        }

        void RestartGame() 
        {
            //Disable buttons
            HideUserItems();            

            try
            {
                deck.Dispose();
                dealer.Dispose();
                customer.Dispose();
            }
            catch (Exception)
            {
                Console.WriteLine("Objects cannot disposed!\n");
            }

            pnlCardsDealer.Controls.Clear();
            pnlCardsPlayer.Controls.Clear();

            StartGame();
        }

        private void HideUserItems()    //Disables buttons and make labels invisible
        {
            DisableButtons();
            lblDealerPt.Visible = false;
            lblCustomerPt.Visible = false;
            lblDealer.Visible = false;
            lblCustomer.Visible = false;
        }

        private void DisableButtons()   //Disables buttons
        {
            btnHit.Enabled = false;
            btnStand.Enabled = false;
            btnHit.BackColor = Color.DarkGray;
            btnStand.BackColor = Color.DarkGray;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void lblMsg_Click(object sender, EventArgs e)
        {

        }
    }
}
