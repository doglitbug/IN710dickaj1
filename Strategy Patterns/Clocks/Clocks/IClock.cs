using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clocks
{
    public interface IClock
    {
        /// <summary>
        /// Turn the clock on
        /// </summary>
        void On();
        /// <summary>
        /// Turn the clock off
        /// </summary>
        void Off();
        /// <summary>
        /// Update the clocks display
        /// </summary>
        void UpdateTimeDisplay();
        /// <summary>
        /// Show the clock
        /// </summary>
        void ShowClock();
        /// <summary>
        /// Hide the clock
        /// </summary>
        void HideClock();
    }
}
