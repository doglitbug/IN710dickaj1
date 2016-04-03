using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressIndicator
{
    public partial class Form1 : Form
    {
        public delegate void trackProgress();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (rbSpinBox.Checked)
            {
                //TODO Do spin box
            }
            else if (rbProgressBar.Checked)
            {
                //TODO Do Progress bar
            }
            else
            {
                //TODO Do track bar
            }
        }
    }
}
