using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    public abstract class Character
    {
        //These are public so that the character can be created
        //TODO Fix accessibility?
        public Head myHead;
        public Body myBody;
        public Legs myLegs;

        protected string name;
        public String Name { get { return name; } }
    }
}
