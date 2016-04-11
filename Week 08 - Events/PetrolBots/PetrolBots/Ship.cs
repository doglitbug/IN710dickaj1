using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBots
{
    public enum EShipState{WANDERING,REFUELING};
    public class Ship : Entity
    {
        //Events that the ship can raise
        public delegate void OutOfFuelEventHandler(Ship subject, EventArgs ea);
        public delegate void FullOfFuelEventHandler(Ship subject, EventArgs ea);
        public event OutOfFuelEventHandler OutOfFuelEvent;
        public event FullOfFuelEventHandler FullOfFuelEvent;

        /// <summary>
        /// 0-100 represent how much fuel is in the Ship
        /// </summary>
        public int fuel;

        /// <summary>
        /// Defines how the ship moves in X/Y directions
        /// </summary>
        public Point delta;

        //What is the ship currently doing?
        public EShipState shipState;

        //TODO randomize the position/delta/size here?(will need rng)
        public Ship(Point startPosition, Point world_size, int size, Point delta, Graphics g)
            : base(startPosition, world_size, size, g)
        {
            this.delta = delta;
            this.fuel = 100;
            this.shipState = EShipState.WANDERING;
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
            //What are we cutrrently doing?
            switch (shipState)
            {
                case EShipState.REFUELING:
                    //We are out of fuel or waiting for a full top up
                    raiseOutOfFuelEvent();
                    break;
                case EShipState.WANDERING:
                    wander();
                    break;
                default:
                    throw new IndexOutOfRangeException();
            }
        }
        private void wander(){
            //Check we actually have fuel left to use!
            if (fuel <= 0)
            {
                shipState = EShipState.REFUELING;
            }
            else
            {
                //Calculate speed so that faster ships run out of fuel quicker
                int speed = (int)Math.Sqrt((Math.Abs(delta.X) + Math.Abs(delta.Y)));
                //Burn that fuel efficently
                fuel = fuel - speed / 2;

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

        public void reFuel(int amount)
        {
            //Add the given amount to the ships supply
            fuel += amount;
            //Check to see if we are full
            if (fuel >= 100)
            {
                //Spill the excess
                fuel = 100;

                //Let bot know we are full
                raiseFullOfFuelEvent();                
            }

        }
        private void raiseOutOfFuelEvent()
        {
            //Sit and wait
            shipState = EShipState.REFUELING;
            //Check someone is listening before raising event or system will crash
            if (OutOfFuelEvent != null)
            {
                OutOfFuelEvent(this, new EventArgs());
            }
        }

        private void raiseFullOfFuelEvent()
        {
            //Go back to wandering around
            shipState = EShipState.WANDERING;

            //Check someone is listening before raising event or system will crash
            if (FullOfFuelEvent != null)
            {
                FullOfFuelEvent(this, new EventArgs());
            }
        }
    }
}
   