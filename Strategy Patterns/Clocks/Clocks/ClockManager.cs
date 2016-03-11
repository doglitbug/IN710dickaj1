using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clocks
{
    public class ClockManager
    {
        /// <summary>
        /// Currently used clock
        /// </summary>
        public IClock currentClock;

        public ClockManager() {}

        public void StartClock()
        {
            throw new NotImplementedException();
        }

        public void StopClock()
        {
            throw new NotImplementedException();
        }

        public void ChangeClock(int clockType)
        {
        switch (clockType)
            {
                case 1:
                    currentClock = new DigitalClock();
                    break;
                case 2:
                    currentClock = new AnalogueClock();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
                    break;
            }
        }
    }
}
