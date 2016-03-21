using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace MixAndMatch
{
    public class Frankenstein_Legs : Legs
    {
        public Frankenstein_Legs()
        {
            this.name = "Frankenstein's legs";
            this.image = new Bitmap("images/Frankenstein_2.png");
        }
    }
}
