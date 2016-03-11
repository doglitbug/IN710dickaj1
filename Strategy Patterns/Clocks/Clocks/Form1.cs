using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clocks
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Clock manager
        /// </summary>
        ClockManager manager;
        public Form1()
        {
            InitializeComponent();
            //TODO Set default clock
            manager = new ClockManager(roundClock);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            manager.StartClock();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            manager.StopClock();
        }

        private void rbDigital_CheckedChanged(object sender, EventArgs e)
        {
            manager.ChangeClock(1);
        }

        private void rbAnalogue_CheckedChanged(object sender, EventArgs e)
        {
            manager.ChangeClock(2);
        }
    }
}
