using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    public class Part
    {
        /// <summary>
        /// Name of this part
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// Preview image of this part
        /// </summary>
        public virtual Bitmap Image { get; set; }
        
        public override string ToString()
        {
            return Name;
        }
    }
}