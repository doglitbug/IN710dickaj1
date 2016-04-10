using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressIndicator
{
    public class ProgressSubject
    {
        public event EventHandler updateEvent;
        public void SlowMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                //Wait for a bit
                System.Threading.Thread.Sleep(500);
                //Check and raise event
                if (updateEvent != null)
                {
                    //EventArgs is expected to be null
                    updateEvent(this, new EventArgs());
                }
            }
        }

    }
}