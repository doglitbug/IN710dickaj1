using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using System.Threading;

namespace Clocks
{
    class DigitalClock:IClock

    {
        private Label clockLabel;
        private System.Timers.Timer aTimer;
        // This delegate enables asynchronous calls for setting
        // the text property on a TextBox control.
        delegate void SetTextCallback(string text);

        public DigitalClock(Label clockLabel)
        {
            //Set label used to display time
            this.clockLabel = clockLabel;
            //Create new timer to update this clock
            aTimer = new System.Timers.Timer(2000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            setText(DateTime.Now.ToString("HH:mm:ss tt"));
        }

        private void setText(String text)
        {
            if (this.clockLabel.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setText);
                clockLabel.Invoke(d, new object[] { text });
            }
            else
            {
                this.clockLabel.Text = text;
            }
        }
        public void On()
        {
            aTimer.Enabled = true;
        }

        public void Off()
        {
            aTimer.Enabled = false;
        }

        public void UpdateTimeDisplay()
        {
            
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
