using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace MixAndMatch
{
    public class Skeleton_Body : Body
    {
        public Skeleton_Body()
        {
            this.name = "Skeleton's body";
            this.image = new Bitmap("images/Skeleton_1.png");
        }
    }
}
