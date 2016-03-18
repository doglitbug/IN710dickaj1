using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    public class Bison:Animal
    {
        public Bison()
        {
            name = "Bison";
            foodType = "Herbivore";
            preferedFood = "Grass";
            //TODO find image and update here
            image = new Bitmap("");
        }
    }
}
