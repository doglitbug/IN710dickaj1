using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDealingApplication
{
    class Deck
    {
        private const int NSUITS = 4;
        private const int NRANKS = 13;

        private Card[] cardArray;

        private Random rand;

        /// <summary>
        /// Create a new unshuffled deck
        /// TODO: Expand for games that play with two decks?
        /// </summary>
        /// <param name="rand">Random Number Generator from Form</param>
        public Deck(Random rand)
        {
            this.rand = rand;

            cardArray = new Card[NRANKS * NSUITS];

            for (int i = 0; i < NSUITS; i++)
            {
                for (int j = 0; j < NRANKS; j++)
                {
                    cardArray[i * NRANKS + j] = new Card((Rank)(j + 2), (Suit)(i));
                }
            }
        }

        /// <summary>
        /// Shuffles the deck by swapping cards around
        /// </summary>
        public void Shuffle()
        {
            for (int i = 0; i < cardArray.Length; i++)
            {
                swap(ref cardArray[i], ref cardArray[rand.Next(cardArray.Length)]);
            }
        }

        /// <summary>
        /// Deals out the given nunber of cards for the given number of players
        /// </summary>
        /// <param name="nHands">Numbed of hands(players) to deal for</param>
        /// <param name="nCards">Number of cards in a hand</param>
        /// <returns>Array of Hands containing cards from the deck</returns>
        public Hand[] DealHands(int nHands, int nCards)
        {
            //TODO Check we dont deal out more cards that there are in a deck?
            Hand[] hands = new Hand[nHands];
            Card[] tempCards = new Card[nCards];

            //Loop through for each player
            for (int i = 0; i < nHands; i++)
            {
                //Loop through and grab the players cards
                for (int j = 0; j < nCards; j++)
                {
                    //Using i*nCards so that we dont always pick the cards from the start of the deck
                    //Would result in all players having the same cards!
                    tempCards[j] = cardArray[(i * nCards) + j];
                }
                //Place the cards picked into the hand
                hands[i] = new Hand(tempCards);

                //Reset the cards picked
                //TODO: Figure out why this is needed!
                tempCards = new Card[nCards];
            }
            return hands;
        }

        /// <summary>
        /// Internal swap for cards based on reference
        /// </summary>
        /// <param name="one">Card one to swap</param>
        /// <param name="two">Card two to swap</param>
        private void swap(ref Card one, ref Card two)
        {
            Card tempCard = one;
            one = two;
            two = tempCard;
        }
    }
}
