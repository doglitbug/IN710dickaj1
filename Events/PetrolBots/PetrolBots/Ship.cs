using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBots
{
    public class Ship:Entity
    {
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
            SolidBrush shipBrush=new SolidBrush(shipColor);

            g.FillEllipse(shipBrush, location.X, location.Y, size, size);
        }

        public override void Move()
        {
            //TODO Check if we have enoyugh fuel to move and dec
            //TODO if no fuel, raise event

            //TODO ---- If filled here, raise event?

            Point newLocation = new Point(location.X + delta.X,
                                        location.Y + delta.Y);

            //Checks bounds and reverses direction if needed
            if ((location.X < size) || (location.X > world_size.X - size))
            {
                delta.X = -delta.X;
            }

            if ((location.Y < size) || (location.Y > world_size.Y - size))
            {
                delta.Y = -delta.Y;
            }

            //Add new co-ords
            location.X += delta.X;
            location.Y += delta.Y;
        }
    }
}
