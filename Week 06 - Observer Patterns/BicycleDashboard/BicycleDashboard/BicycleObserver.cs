using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleDashboard
{
    public abstract class BicycleObserver:IObserver
    {
        protected int currentRPM;
        protected double currentComputedValue;
        protected BicycleSubject myBicycleSubject;
        protected Label displayLabel;

        /// <summary>
        /// Accepts the new data value and perferms computations
        /// Each child writes his own
        /// </summary>
        /// <param name="currentRPM">Current RPM for the bicycle</param>
        public abstract void Update(int currentRPM);

        /// <summary>
        /// Display the current calculated data
        /// </summary>
        public void Display()
        {
            displayLabel.Text = currentComputedValue.ToString("F2");
        }

        public BicycleObserver(Label displayLabel, BicycleSubject myBicycleSubject){
            this.displayLabel=displayLabel;
            this.myBicycleSubject=myBicycleSubject;            
            currentRPM=0;
            currentComputedValue=0;

            myBicycleSubject.AddObserver(this);
        }
    }
}
