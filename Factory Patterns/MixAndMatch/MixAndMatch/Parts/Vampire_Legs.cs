using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace MixAndMatch
{
    public class Vampire_Legs : Legs
    {
        public Vampire_Legs()
        {
            this.name = "Vampire's legs";
            this.image = new Bitmap("images/Vampire_2.png");
        }
    }
}
