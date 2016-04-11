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

        const int MAXSPEED = 10;
        const int NUMSHIPS = 10;

        //List of bots and ships
        Ship[] ships;
        Bot[] bots;

        public World(Random rng, Point world_size, Graphics g)
        {
            this.rng = rng;
            this.world_size = world_size;
            this.g = g;

            //Create ships
            createShips();
            //Create bots
            createBots();

            //TODO Register listeners
        }

        private void createShips()
        {
            int shipSize=50;
            ships = new Ship[NUMSHIPS];
            for (int i = 0; i < ships.Length; i++)
            {
                //Create start position

               Point startPoint=new Point(rng.Next(shipSize,world_size.X-shipSize+1),
                                          rng.Next(shipSize,world_size.Y-shipSize+1));
                //Create delta
                Point delta = new Point(rng.Next(-MAXSPEED, MAXSPEED + 1),
                                        rng.Next(-MAXSPEED, MAXSPEED + 1));
                //Create new ship
                ships[i] = new Ship(startPoint, world_size, shipSize, delta, g);
            }
        }

        private void createBots()
        {
            int botSize = 20;
            bots = new Bot[NUMSHIPS];
            for (int i=0;i<bots.Length;i++){
                //Create start position
                Point startPoint = new Point( (i+5)*botSize,
                                               world_size.Y-botSize*2);
                //Create a color for the bot
                int colorValue = (int)(255 / (NUMSHIPS/(i+1)));
                Color botColor = Color.FromArgb(colorValue, 255-colorValue, 255-colorValue);
                //Create bot and pass in 
                bots[i] = new Bot(startPoint, world_size, botSize, g, ships[i], botColor);
            }
        }

        public void Run()
        {
            //Loop through all ships and call Move()
            foreach (Ship s in ships)
            {
                s.Move();
            }
            //TODO loop through all bots and call Move()?
        }

        public void Draw()
        {
            //Loop through all ships and call Draw()
            foreach(Ship s in ships){
                s.Draw();
            }
            //Loop through all bots and call Draw();
            foreach (Bot b in bots)
            {
                b.Draw();
            }
        }
    }
}
