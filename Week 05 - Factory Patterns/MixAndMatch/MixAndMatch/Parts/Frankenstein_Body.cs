using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace MixAndMatch
{
    public class Frankenstein_Body : Body
    {
        public Frankenstein_Body()
        {
            this.name = "Frankenstein's body";
            this.image = new Bitmap("images/Frankenstein_1.png");
        }
    }
}
