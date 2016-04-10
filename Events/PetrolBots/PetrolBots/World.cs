using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBots
{
    public class World
    {
        /// <summary>
        /// Random Number generator from form
        /// </summary>
        Random rng;
        /// <summary>
        /// Max size of the world
        /// </summary>
        Point world_size;
        /// <summary>
        /// Graphics context to draw to
        /// </summary>
        Graphics g;

        //TODO list of bots and ships
        public World(Random rng, Point world_size, Graphics g)
        {
            this.rng = rng;
            this.world_size = world_size;
            this.g = g;

            //TODO Create ships

            //TODO Create bots

            //TODO Register listeners
        }

        public void Run()
        {
            //TODO Loop through all shiups and call Move()

            //TODO loop through all bots and call Move()?
        }

        public void Draw()
        {
            //TODO Clear screen

            //TODO Loop through all ships and call Draw()

            //TODO Loop through all bots and call Draw();
        }
    }
}
