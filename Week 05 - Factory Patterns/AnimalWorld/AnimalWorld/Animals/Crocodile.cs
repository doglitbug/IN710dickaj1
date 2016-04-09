using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    public class Crocodile : Animal
    {
        public Crocodile()
        {
            name = "Crocodile";
            foodType = "Carnivore";
            preferedFood = "Chickens";
            //TODO find image and update here
            image = new Bitmap("");
        }
    }
}
