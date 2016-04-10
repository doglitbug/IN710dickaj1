using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressIndicator
{
    public abstract class ProgressObserverBase
    {
        protected ProgressSubject subject;
        protected object thingToUpdate;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="subject">Subject to observe</param>
        public ProgressObserverBase(ProgressSubject subject, object thingToUpdate)
        {
            //Keep reference to the subject
            this.subject = subject;
            //Keep reference to the object to update
            this.thingToUpdate = thingToUpdate;

            //Create a new handler
            EventHandler handler = new EventHandler(incrementDisplay);
            //Register handler with subject;
            subject.updateEvent+=handler;
        }

        public abstract void incrementDisplay(object subject, EventArgs ea);
    }
}