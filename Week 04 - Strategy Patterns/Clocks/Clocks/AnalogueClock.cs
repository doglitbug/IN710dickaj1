using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clocks
{
    class AnalogueClock:IClock
    {
        AnalogClockControl.AnalogClock thisClock;
        public AnalogueClock(AnalogClockControl.AnalogClock analogueClockFromForm)
        {
            thisClock = analogueClockFromForm;
        }
        public void On()
        {
            thisClock.Start();
        }

        /// <summary>
        /// Turn this clock off
        /// </summary>
        public void Off()
        {
            thisClock.Stop();
        }

        /// <summary>
        /// Do nothing as this clock auto updates
        /// </summary>
        public void UpdateTimeDisplay() { }

        public void ShowClock()
        {
            thisClock.Visible = true;
        }

        public void HideClock()
        {
            thisClock.Visible = false;
        }
    }
}
