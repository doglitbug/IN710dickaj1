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
        public Bot(Point startPosition, Point world_size, int size, Graphics g, Ship subject)
            : base(startPosition, world_size, size, g) {
            //Keep reference to subject
            this.subject = subject;
            //Create a new handlers
            Ship.OutOfFuelEventHandler OutOfFuelHandle = new Ship.OutOfFuelEventHandler(OutOfFuelCalled);
            Ship.FullOfFuelEventHandler FullOfFuelHandle = new Ship.FullOfFuelEventHandler(FullOfFuelCalled);
            //Register handlers
            subject.OutOfFuelEvent += OutOfFuelHandle;
            subject.FullOfFuelEvent += FullOfFuelHandle;
            }
        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }

        public void OutOfFuelCalled(Ship subject, EventArgs ea)
        {
            throw new NotImplementedException();
        }
        public void FullOfFuelCalled(Ship subject, EventArgs ea)
        {
            throw new NotImplementedException();
        }
    }
}
