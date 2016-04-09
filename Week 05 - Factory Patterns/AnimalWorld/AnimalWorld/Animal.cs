using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    class Animal
    {
        /// <summary>
        /// Type of animal, eg Bison or wolf
        /// </summary>
        protected string name;
        /// <summary>
        /// Herbivore or carnivore
        /// TODO refactor into enum?
        /// </summary>
        protected string foodType;
        /// <summary>
        /// What they prefer to eat, eg fish or grass
        /// </summary>
        protected string preferedFood;
        /// <summary>
        /// Image for animal
        /// </summary>
        protected Bitmap image;


        //Getter/setters

        /// <summary>
        /// get image of animal as a Bitmap
        /// </summary>
        public Bitmap Image
        { get { return image; } }

        //Methods

        /// <summary>
        /// String representation of this animal
        /// </summary>
        public override string toString(){
            string displayString="I am "+name;
            displayString+=". I am a "+foodType;
            displayString+=". I eat "+preferedFood;
            return displayString;
        }
    }
}
