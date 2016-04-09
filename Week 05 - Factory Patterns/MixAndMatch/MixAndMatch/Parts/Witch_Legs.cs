using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace MixAndMatch
{
    public class Witch_Legs : Legs
    {
        public Witch_Legs()
        {
            this.name = "Witch's legs";
            this.image = new Bitmap("images/Witch_2.png");
        }
    }
}
