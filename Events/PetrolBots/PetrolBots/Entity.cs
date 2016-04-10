using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBots
{
    /// <summary>
    /// Represents an object in the World such as a ship or bot
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        /// Objects location in the world
        /// </summary>
        protected Point location { get; set; }

        /// <summary>
        /// Max size of the world
        /// </summary>
        protected Point world_size { get; set; }

        /// <summary>
        /// Size of the object
        /// </summary>
        protected int size { get; set; }

        public Entity(Point startPosition, Point world_size, int size)
        {
            this.location = startPosition;
            this.world_size = world_size;
            this.size = size;
        }

        public abstract void Draw(Graphics g);

        public abstract void Move();
    }
}
