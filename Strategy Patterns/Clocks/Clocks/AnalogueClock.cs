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

        public void Off()
        {
            thisClock.Stop();
        }

        public void UpdateTimeDisplay()
        {
            throw new NotImplementedException();
        }

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
