using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBots
{
    public class Bot:Entity
    {
        private Ship subject;
        private Color botColor;
        private Point startPosition;
        public Bot(Point startPosition, Point world_size, int size, Graphics g, Ship subject, Color botColor)
            : base(startPosition, world_size, size, g) {
            //Keep reference to subject/color
            this.subject = subject;
            this.botColor = botColor;
            this.startPosition = startPosition;

            //Create a new handlers
            Ship.OutOfFuelEventHandler OutOfFuelHandle = new Ship.OutOfFuelEventHandler(OutOfFuelCalled);
            Ship.FullOfFuelEventHandler FullOfFuelHandle = new Ship.FullOfFuelEventHandler(FullOfFuelCalled);
            
            //Register handlers
            subject.OutOfFuelEvent += OutOfFuelHandle;
            subject.FullOfFuelEvent += FullOfFuelHandle;
            }
        public override void Draw()
        {
            //Create a brush
            SolidBrush botBrush = new SolidBrush(botColor);
            //Draw bot
            g.FillEllipse(botBrush, location.X - size*2, location.Y - size*2, size, size);
        }

        public override void Move()
        {
            
        }

        public void OutOfFuelCalled(Ship subject, EventArgs ea)
        {
            //Move to location
            this.location = subject.location;
            //Increment the fuel a bit
            subject.reFuel(3);
        }
        public void FullOfFuelCalled(Ship subject, EventArgs ea)
        {
            //Move home
            this.location = startPosition;
        }
    }
}
