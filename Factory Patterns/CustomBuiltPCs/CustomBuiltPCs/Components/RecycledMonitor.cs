using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomBuiltPCs
{
    class RecycledMonitor : Monitor
    {
        public RecycledMonitor()
        {
            this.Description = "Standard office monitor but recycled";
            this.Price = 20;
        }
    }
}
