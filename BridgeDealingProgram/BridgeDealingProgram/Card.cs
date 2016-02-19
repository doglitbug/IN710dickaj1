using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDealingProgram
{
    class Card
    {
        private Suit suit;
        private Rank rank;

        public Card(Rank rank, Suit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }
        public override String ToString()
        {
            return (rank.ToString() + " of " + suit.ToString());
        }

        public int getHCP()
        {
            int value = 0;
            switch (rank)
            {
                
            }
            return value;
        }
    }
}
