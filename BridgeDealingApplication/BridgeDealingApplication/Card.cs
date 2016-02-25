using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDealingApplication
{
    class Card : IComparable
    {
        private Suit suit;
        private Rank rank;

        /// <summary>
        /// Default comparator for Cards to be used with Array.sort
        /// </summary>
        /// <param name="obj">Other object to compare to</param>
        /// <returns>0 if the same or -n/+n depending on which comes first</returns>
        int IComparable.CompareTo(object obj)
        {
            //Get other object and dereference
            Card other=(Card)obj;

            //Check sorting by suit first
            if (this.suit == other.suit)
            {
                //If the same suit, sort by rank descending
                return (other.rank-this.rank);
            }
            else
            {
                //Sort by the suit
                return (this.suit - other.suit);
            }
        }

        /// <summary>
        /// Create a new card with the given parameters
        /// </summary>
        /// <param name="rank">Card Rank</param>
        /// <param name="suit">Card Suit</param>
        public Card(Rank rank, Suit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        /// <summary>
        /// Override toString and reformat the output
        /// </summary>
        /// <returns>String representation of the card</returns>
        public override String ToString()
        {
            return (rank.ToString() + " of " + suit.ToString());
        }

        /// <summary>
        /// Find out the High Card Point of this card
        /// </summary>
        /// <returns>High Card Point of the card</returns>
        public int getHCP()
        {
            int value = 0;
            switch (rank)
            {
                case Rank.ACE:
                    value = 4;
                    break;
                case Rank.KING:
                    value = 3;
                    break;
                case Rank.QUEEN:
                    value = 2;
                    break;
                case Rank.JACK:
                    value = 1;
                    break;
                default:
                    break;
            }
            return value;
        }

        /// <summary>
        /// Gets the cards Rank
        /// </summary>
        /// <returns>Rank</returns>
        public Rank getRank()
        {
            return this.rank;
        }

        /// <summary>
        /// Gets the cards Suit
        /// </summary>
        /// <returns>Suit</returns>
        public Suit getSuit()
        {
            return this.suit;
        }
    }

}
