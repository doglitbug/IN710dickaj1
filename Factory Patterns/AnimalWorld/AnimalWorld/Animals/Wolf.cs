﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    public class Wolf : Animal
    {
        public Wolf()
        {
            name = "Wolf";
            foodType = "Carnivore";
            preferedFood = "Rabbits";
            //TODO find image and update here
            image = "";
        }
    }
}
