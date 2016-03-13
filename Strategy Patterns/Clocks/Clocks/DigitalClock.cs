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
            aTimer = new System.Timers.Timer(1000);
            //Set event to fire after set interval
            aTimer.Elapsed += OnTimedEvent;
            //Shall we reset after firing?
            aTimer.AutoReset = true;
            //Are we currently working?
            aTimer.Enabled = true;
        }

        /// <summary>
        /// Update the label with the current time
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            setText(DateTime.Now.ToString("HH:mm:ss"));
        }

        /// <summary>
        /// Sets the test of the lable in a thread safe manner
        /// https://msdn.microsoft.com/library/ms171728%28v=vs.100%29.aspx
        /// </summary>
        /// <param name="text">test to place on the label</param>
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
