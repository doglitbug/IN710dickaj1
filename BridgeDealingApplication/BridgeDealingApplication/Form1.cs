using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridgeDealingApplication
{
    public partial class Form1 : Form
    {
        private const int NPLAYERS = 4;
        private const int NSIZEOFHAND = 13;
        //Card deck
        Deck myDeck;
        //Hold the players hands
        Hand[] theHands;

        public Form1()
        {
            //Random number generator
            Random rand = new Random();

            //Create a new playing deck
            myDeck = new Deck(rand);

            InitializeComponent();
        }

        private void buttonDeal_Click(object sender, EventArgs e)
        {
            dealAGame();
            displayHands();
        }

        private void dealAGame()
        {
            //Shuffle the cards in the deck
            myDeck.Shuffle();

            //Reset the players hands
            theHands = new Hand[NPLAYERS];

            //Deal the hands and return to a hand array
            theHands = myDeck.DealHands(NPLAYERS, NSIZEOFHAND);
        }

        private void displayHands()
        {
            //Clear previous game from listBox
            listBoxOutput.Items.Clear();

            //Loop through all hands
            for (int i = 0; i < theHands.Length; i++)
            {
                //Display hand in listBox

                //Get hand name and display
                String name=((Seat)i).ToString();
                listBoxOutput.Items.Add(name);
                listBoxOutput.Items.Add("--------");

                //Display cards in the hand

                //Get the cards
                Card[] cards = theHands[i].getCards();
                //Loop through them
                for (int j = 0; j < cards.Length; j++)
                {
                    //Add card to listbox
                    listBoxOutput.Items.Add(cards[j]);
                }

                    //Seperator at bottom of display
                    listBoxOutput.Items.Add("");
                    listBoxOutput.Items.Add("");
            }

        }
    }
}
