using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    public abstract class FireAlarmObserverBase
    {
        protected FireAlarmSubject subject;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="subject">Subject to observe</param>
        public FireAlarmObserverBase(FireAlarmSubject subject)
        {
            //Keep reference to subject
            this.subject = subject;
            //Create a new handler
            FireAlarmSubject.FireEventHandler handler = new FireAlarmSubject.FireEventHandler(FireAlarmHandlerMethod);

            //Register handler with subject
            subject.FireEvent += handler;
        }

        /// <summary>
        /// Method that is executed when event is fired
        /// </summary>
        /// <param name="fireSubject">Subject that fired event</param>
        /// <param name="fe">Event arguments</param>
        public abstract void FireAlarmHandlerMethod(object fireSubject, FireAlarmEventArgs fe);
    }
}
