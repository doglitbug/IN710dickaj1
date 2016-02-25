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
                //listBoxOutput.Items.Add(name);
                //listBoxOutput.Items.Add("--------");

                //Display cards in the hand

                //Get the cards
                Card[] cards = theHands[i].getCards();
                //Sort the hand first
                Array.Sort(cards);
                //Loop through them

                string[] tempStrings = new string[4];
                //TODO, have these letters come from the first letter of each rank?
                //Ranks are not in the order to be displayed
                tempStrings[0] = "S:\t";
                tempStrings[1] = "H:\t";
                tempStrings[2] = "D:\t";
                tempStrings[3] = "C:\t";

                //Loop through the hand and add each card to it string to be printed
                //Assume cards are already sorted

                foreach(Card card in cards)
                {
                    string ourCardCode = "";

                    //Create our own numbering convention for the cards
                    //Adding two because previous code adds two for the rank
                    switch (card.getRank())
                    {
                        case Rank.ACE:
                            ourCardCode = "A";
                            break;
                        case Rank.KING:
                            ourCardCode = "K";
                            break;
                        case Rank.QUEEN:
                            ourCardCode = "Q";
                            break;
                        case Rank.JACK:
                            ourCardCode = "J";
                            break;
                        case Rank.TEN:
                            ourCardCode = "T";
                            break;

                        //If not a picture card(or Ace) its is a number
                        default:
                            ourCardCode = ((int)(card.getRank())).ToString();
                            break;
                    }

                    //Add the card to the list under the correct suit list
                    tempStrings[(int)card.getSuit()] += ourCardCode+" ";
                }

                //Add totals to listbox
                //Not using for loop because we want a different order (SHDC instead of original CDHS)
               foreach(String text in tempStrings)
                {
                    listBoxOutput.Items.Add(text);
                }

                //Add HCP and player seperator to box
               listBoxOutput.Items.Add("HCP: " + theHands[i].getHCP());
               listBoxOutput.Items.Add(" -------------------------------------------------");
            }

        }
    }
}
