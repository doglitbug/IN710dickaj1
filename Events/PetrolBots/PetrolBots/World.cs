﻿using System;
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

        const int MAXSPEED = 15;
        const int NUMSHIPS = 5;

        //TODO list of bots and ships
        Ship[] ships;

        public World(Random rng, Point world_size, Graphics g)
        {
            this.rng = rng;
            this.world_size = world_size;
            this.g = g;

            //Create ships
            createShips();
            //TODO Create bots

            //TODO Register listeners
        }

        private void createShips()
        {
            int shipSize=20;
            ships = new Ship[NUMSHIPS];
            for (int i = 0; i < ships.Length; i++)
            {
                //Create start position

               Point startPoint=new Point(rng.Next(-world_size.X+shipSize,world_size.X-shipSize+1),
                                          rng.Next(-world_size.Y+shipSize,world_size.Y-shipSize+1));
                //Create delta
                Point delta = new Point(rng.Next(-MAXSPEED, MAXSPEED + 1),
                                        rng.Next(-MAXSPEED, MAXSPEED + 1));
                //Create new ship
                ships[i] = new Ship(startPoint, world_size, shipSize, delta, g);
            }
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
