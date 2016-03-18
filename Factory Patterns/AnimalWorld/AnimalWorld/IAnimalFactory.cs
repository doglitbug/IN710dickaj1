using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    
    /// <summary>
    /// Interface for an animal factory
    /// </summary>
    public interface IAnimalFactory
    {
        /// <summary>
        /// Creates a new animal given the animal code
        /// </summary>
        /// <param name="animalCode">Integer representing which animal to create</param>
        /// <returns>New animal</returns>
        Animal createAnimal(int animalCode);
    }
}
