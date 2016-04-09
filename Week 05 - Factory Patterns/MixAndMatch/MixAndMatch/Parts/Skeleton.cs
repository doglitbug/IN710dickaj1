using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    public class Skeleton : Character
    {
        /// <summary>
        /// Create a new Skeleton
        /// </summary>
        public Skeleton()
        {
            this.myHead = new Skeleton_Head();
            this.myBody = new Skeleton_Body();
            this.myLegs = new Skeleton_Legs();
            this.name = "Skeleton";
        }
    }
}
