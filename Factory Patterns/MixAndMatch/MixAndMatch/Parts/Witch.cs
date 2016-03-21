using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    public class Witch : Character
    {
        /// <summary>
        /// Create a new Witch
        /// </summary>
        public Witch()
        {
            this.myHead = new Witch_Head();
            this.myBody = new Witch_Body();
            this.myLegs = new Witch_Legs();
            this.name = "Witch";
        }
    }
}
