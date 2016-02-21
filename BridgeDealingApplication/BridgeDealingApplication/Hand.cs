using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDealingApplication
{
    class Hand
    {
        private Card[] cards;
        /// <summary>
        /// Create a new Hand
        /// </summary>
        /// <param name="cards">An array of cards to place in the hand</param>
        public Hand(Card[] cards)
        {
            this.cards = cards;
        }

        /// <summary>
        /// Goes through all cards in the hand and counts up the High Card Points
        /// </summary>
        /// <returns>Total High Card Points</returns>
        public int getHCP()
        {
            int value = 0;
            for (int i = 0; i < cards.Length; i++)
            {
                value += cards[i].getHCP();
            }

            return value;
        }

        /// <summary>
        /// Accessor for cards in the hand
        /// </summary>
        /// <returns>Array of cards</returns>
        public Card[] getCards(){
            return this.cards;
        }
    }
}
