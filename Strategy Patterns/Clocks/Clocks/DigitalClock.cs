using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Clocks
{
    class DigitalClock:IClock

    {
        Label clockLabel;
       

        public DigitalClock(Label clockLabel)
        {
            this.clockLabel = clockLabel;

        }
        public void On()
        {
            throw new NotImplementedException();
        }

        public void Off()
        {
            throw new NotImplementedException();
        }

        public void UpdateTimeDisplay()
        {
            throw new NotImplementedException();
        }

        public void ShowClock()
        {
            clockLabel.Visible = true;
        }

        public void HideClock()
        {
            clockLabel.Visible = false;
        }
    }
}
