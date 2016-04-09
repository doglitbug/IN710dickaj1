using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireAlarm
{
    public partial class Form1 : Form
    {
        FireAlarmSubject FireAlarm;
        public Form1()
        {
            InitializeComponent();
            //Create subject
            FireAlarm = new FireAlarmSubject();

            //Create observer(s)
            InstructionsObserver observer1 = new InstructionsObserver(FireAlarm);
            //TODO beep 
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            //Hold arguments
            EFireCategory eventArgs;
            //Find which category
            if (rbMinor.Checked)
            {
                eventArgs = EFireCategory.MINOR;
            }
            else if (rbSerious.Checked)
            {
                eventArgs = EFireCategory.SERIOUS;
            }
            else
            {
                eventArgs = EFireCategory.INFERNO;
            }

            //Fire event
            FireAlarm.onFireEvent(eventArgs);
        }
    }
}
