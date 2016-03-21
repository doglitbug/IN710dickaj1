using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    public class Fairy : Character
    {
        /// <summary>
        /// Create a new Fairy
        /// </summary>
        public Fairy()
        {
            this.myHead = new Fairy_Head();
            this.myBody = new Fairy_Body();
            this.myLegs = new Fairy_Legs();
            this.name = "Fairy";
        }
    }
}
