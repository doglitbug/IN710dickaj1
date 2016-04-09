using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace MixAndMatch
{
    public class Vampire_Body : Body
    {
        public Vampire_Body()
        {
            this.name = "Vampire's body";
            this.image = new Bitmap("images/Vampire_1.png");
        }
    }
}
