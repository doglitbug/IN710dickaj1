using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressIndicator
{
    /// <summary>
    /// This is a combined observer for each type of progressbar
    /// Basically it just looks at the type of object you stored in thingToupdate and increments that
    /// </summary>
    class CombinedObserver
    {
        protected ProgressSubject subject;
        protected object thingToUpdate;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="subject">Subject to observe</param>
        /// <param name="thingToUpdate">Object that needs updated</param>
        public CombinedObserver(ProgressSubject subject, object thingToUpdate)
        {
            //Keep reference to the subject
            this.subject = subject;
            //Keep reference to the object to update
            this.thingToUpdate = thingToUpdate;

            //Create a new handler
            EventHandler handler = new EventHandler(incrementDisplay);

            //Register handler with subject;
            subject.updateEvent += handler;
        }

        /// <summary>
        /// Increment the observers form item
        /// </summary>
        /// <param name="subject">Subject that raised event</param>
        /// <param name="ea">Event Arguements</param>
        public void incrementDisplay(object subject, EventArgs ea)
        {
            //Find out what the type of object is as a string(cant switch on object type...)
            //https://social.msdn.microsoft.com/Forums/vstudio/en-US/77a76b92-f56b-4e83-8ef6-3a3ed279ed8c/how-do-i-use-an-objects-type-as-the-test-condition-in-a-switch-statement?forum=csharpgeneral
            String updateType=thingToUpdate.GetType().ToString();
            
            //Switch on 'type', cast to object and increment
            switch (updateType)
            {
                case "System.Windows.Forms.NumericUpDown":
                    NumericUpDown thing = (NumericUpDown)thingToUpdate;
                    thing.Value++;
                    //Needed as this object is tricky and wont update on its own
                    thing.Update();
                break;

                case "System.Windows.Forms.TrackBar":
                    ((TrackBar)thingToUpdate).Value++;
                break;

                case "System.Windows.Forms.ProgressBar":
                ((ProgressBar)thingToUpdate).PerformStep();
                break;

                default:
                    //Unknown object
                    throw new ArgumentException();
            }
        }
    }
}