using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Clocks
{
    public class ClockManager
    {
        /// <summary>
        /// Currently used clock
        /// </summary>
        public IClock currentClock;
        private IClock digitalClockObject;
        private IClock analogueClockObject;

        public ClockManager(Label digitalClockLabel, AnalogClockControl.AnalogClock analogueClockFromForm)
        {
            //Create the clocks
            //Create Digital Clock
            digitalClockObject = new DigitalClock(digitalClockLabel);
            //Create Analogue clock
            analogueClockObject = new AnalogueClock(analogueClockFromForm);

            //Set default clock
            currentClock = analogueClockObject;
        }

        public void UpdateTimeDisplay()
        {
            currentClock.UpdateTimeDisplay();
        }

        public void StartClock()
        {
            currentClock.On();
        }

        public void StopClock()
        {
            currentClock.Off();
        }

        /// <summary>
        /// Change the current clock type
        /// </summary>
        /// <param name="clockType">1 - Digital 2 - Analogue</param>
        public void ChangeClock(int clockType)
        {
            //Hide last clock
            currentClock.HideClock();

            switch (clockType)
            {
                case 1:
                    currentClock = digitalClockObject;
                    break;
                case 2:
                    currentClock = analogueClockObject;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            //Show the new clock
            currentClock.ShowClock();
            //TODO refactor the hide/show as this may cause flicker
        }
    }
}
