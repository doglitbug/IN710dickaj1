using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDealingProgram
{
    class Program
    {
        private const int NPLAYERS = 4;
        private const int NSIZEOFHAND = 13;
        static void Main(string[] args)
        {
            //Random number generator
            Random rand = new Random();

            //Hold the players hands
            Hand[] theHands = new Hand[NPLAYERS];

            //Create a new playing deck
            Deck myDeck = new Deck(rand);

            //Shuffle the cards in the deck
            myDeck.Shuffle();

            //Deal the hands and return to a hand array
            theHands=myDeck.DealHands(NPLAYERS,NSIZEOFHAND);

            Console.Out.WriteLine(theHands);

        }
    }
}
