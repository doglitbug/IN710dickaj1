using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    public class Vampire : Character
    {
        /// <summary>
        /// Create a new Vampire
        /// </summary>
        public Vampire()
        {
            this.myHead = new Vampire_Head();
            this.myBody = new Vampire_Body();
            this.myLegs = new Vampire_Legs();
            this.name = "Vampire";
        }
    }
}
