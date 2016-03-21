using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace MixAndMatch
{
    public class Werewolf_Body : Body
    {
        public Werewolf_Body()
        {
            this.name = "Werewolf's body";
            this.image = new Bitmap("images/Werewolf_1.png");
        }
    }
}
