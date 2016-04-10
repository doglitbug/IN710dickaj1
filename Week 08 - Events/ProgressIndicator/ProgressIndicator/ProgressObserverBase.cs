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

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="subject">Subject to observe</param>
        public ProgressObserverBase(ProgressSubject subject)
        {
            //Keep reference to the subject
            this.subject = subject;
            //Create a new handler
            EventHandler handler = new EventHandler(incrementDisplay);
            //Register handler with subject;
            subject.updateEvent+=handler;
        }

        public abstract void incrementDisplay(object subject, EventArgs ea);
    }
}