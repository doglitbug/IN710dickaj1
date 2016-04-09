using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomBuiltPCs
{
    class WidescreenMonitor:Monitor
    {
        public WidescreenMonitor()
        {
            this.Description = "24 in wide screen monitor";
            this.Price=150;
        }
    }
}
