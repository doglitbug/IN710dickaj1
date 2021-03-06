﻿using System;
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
        public Point location;

        /// <summary>
        /// Max size of the world
        /// </summary>
        protected Point world_size;

        /// <summary>
        /// Size of the object
        /// </summary>
        protected int size;

        /// <summary>
        /// Graphics context to draw to
        /// </summary>
        protected Graphics g;

        public Entity(Point startPosition, Point world_size, int size, Graphics g)
        {
            this.location = startPosition;
            this.world_size = world_size;
            this.size = size;
            this.g = g;
        }

        public abstract void Draw();

        public abstract void Move();
    }
}
