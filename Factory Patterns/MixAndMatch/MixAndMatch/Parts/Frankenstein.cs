using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    public class Frankenstein : Character
    {
        /// <summary>
        /// Create a new Frankenstein
        /// </summary>
        public Frankenstein()
        {
            this.myHead = new Frankenstein_Head();
            this.myBody = new Frankenstein_Body();
            this.myLegs = new Frankenstein_Legs();
            this.name = "Frankenstein";
        }
    }
}
