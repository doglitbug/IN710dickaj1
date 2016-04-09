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
        protected string name;
        /// <summary>
        /// Preview image of this part
        /// </summary>
        protected Bitmap image;

        /// <summary>
        /// Get the name of this part
        /// </summary>
        public string Name { get { return name; } }
        /// <summary>
        /// Get the preview image for this part
        /// </summary>
        public Bitmap Image {get { return image; }}
        public override string ToString()
        {
            return name;
        }
    }
}