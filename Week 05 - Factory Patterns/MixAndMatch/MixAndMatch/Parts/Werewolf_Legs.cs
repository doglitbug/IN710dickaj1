using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace MixAndMatch
{
    public class Werewolf_Legs : Legs
    {
        public Werewolf_Legs()
        {
            this.name = "Werewolf's legs";
            this.image = new Bitmap("images/Werewolf_2.png");
        }
    }
}
