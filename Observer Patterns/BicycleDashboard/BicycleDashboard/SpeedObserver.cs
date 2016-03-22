using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleDashboard
{
    class SpeedObserver:BicycleObserver
    {
        public override void Update(int currentRPM)
        {
            currentComputedValue = currentRPM * 205 * 60 / 100;
        }
    }
}
