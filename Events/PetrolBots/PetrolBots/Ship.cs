using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBots
{
    public class Ship : Entity
    {
        //Events that the ship can raise
        public event EventHandler OutOfFuelEvent;
        public event EventHandler FullOfFuelEvent;

        /// <summary>
        /// 0-100 represent how much fuel is in the Ship
        /// </summary>
        public int fuel;

        /// <summary>
        /// Defines how the ship moves in X/Y directions
        /// </summary>
        public Point delta;


        //TODO randomize the position/delta/size here?(will need rng)
        public Ship(Point startPosition, Point world_size, int size, Point delta, Graphics g)
            : base(startPosition, world_size, size, g)
        {
            this.delta = delta;
            this.fuel = 100;
        }

        public override void Draw()
        {
            //Calculate a color based on fuel
            double fuelRatio = fuel / 100.0;
            double redValue = 255 * fuelRatio;
            //Get color
            Color shipColor = Color.FromArgb((int)redValue, 0, 0);
            //Get a brush
            SolidBrush shipBrush = new SolidBrush(shipColor);

            g.FillRectangle(shipBrush, location.X - size, location.Y - size, size, size);
        }

        public override void Move()
        {
            //Check to see if we are full of fuel from a refilling
            if (fuel > 100)
            {
                raiseFullOfFuelEvent();
            }

            //Calculate speed so that faster ships run out of fuel quicker
            int speed = (int) Math.Sqrt((Math.Abs(delta.X) + Math.Abs(delta.Y)));
            //Burn that fuel efficently
            fuel = fuel - speed/2;

            //Check we actually have fuel left to use!
            if (fuel <= 0)
            {
                raiseOutOfFuelEvent();
            }
            else
            {
                //Move ship
                Point newLocation = new Point(location.X + delta.X,
                                            location.Y + delta.Y);

                //Checks bounds and reverses direction if needed
                if ((location.X < size) || (location.X > world_size.X))
                {
                    delta.X = -delta.X;
                }

                if ((location.Y < size) || (location.Y > (world_size.Y - size)))
                {
                    delta.Y = -delta.Y;
                }

                //Add new co-ords
                location.X += delta.X;
                location.Y += delta.Y;
            }
        }


        private void raiseOutOfFuelEvent()
        {
            fuel = 0;
            //Check someone is listening before raising event or system will crash
            if (OutOfFuelEvent != null)
            {
                OutOfFuelEvent(this, new EventArgs());
            }
        }

        private void raiseFullOfFuelEvent()
        {
            fuel = 100;
            //Check someone is listening before raising event or system will crash
            if (FullOfFuelEvent != null)
            {
                FullOfFuelEvent(this, new EventArgs());
            }
        }
    }
}
   