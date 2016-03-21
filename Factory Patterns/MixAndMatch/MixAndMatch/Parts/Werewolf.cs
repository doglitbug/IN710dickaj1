using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    public class Werewolf : Character
    {
        /// <summary>
        /// Create a new Werewolf
        /// </summary>
        public Werewolf()
        {
            this.myHead = new Werewolf_Head();
            this.myBody = new Werewolf_Body();
            this.myLegs = new Werewolf_Legs();
            this.name = "Werewolf";
        }
    }
}
