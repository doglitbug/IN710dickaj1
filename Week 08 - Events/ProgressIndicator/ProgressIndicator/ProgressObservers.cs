using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressIndicator
{
    /// <summary>
    /// Observer for NumericUpDown
    /// </summary>
    public class NumericUpDownObserver : ProgressObserverBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="subject">Subject to observe</param>
        /// <param name="thingToUpdate">Object that is updated</param>
        public NumericUpDownObserver(ProgressSubject subject, object thingToUpdate) : base(subject,thingToUpdate) { }

        /// <summary>
        /// method to execute with event is fired
        /// </summary>
        /// <param name="subject">Subject that fired event</param>
        /// <param name="ea">Arguments</param>
        public override void incrementDisplay(object subject, EventArgs ea)
        {
            //Cast thingToUpdate to the required object
            NumericUpDown thing = (NumericUpDown)thingToUpdate;
            thing.Value++;
            thing.Update();
        }
    }

    /// <summary>
    /// Observer for ProgressBar
    /// </summary>
    public class ProgressBarObserver : ProgressObserverBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="subject">Subject to observe</param>
        /// <param name="thingToUpdate">Object that is updated</param>
        public ProgressBarObserver(ProgressSubject subject, object thingToUpdate) : base(subject, thingToUpdate) { }

        /// <summary>
        /// method to execute with event is fired
        /// </summary>
        /// <param name="subject">Subject that fired event</param>
        /// <param name="ea">Arguments</param>
        public override void incrementDisplay(object subject, EventArgs ea)
        {
            //Cast thingToUpdate to the required object
            ProgressBar thing = (ProgressBar)thingToUpdate;
            thing.PerformStep();
            //thing.Update();
        }
    }
}
