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
        ProgressSubject slowWorker;
        public Form1()
        {
            InitializeComponent();

            //Create subject
            slowWorker = new ProgressSubject();

            //Create observers
            new NumericUpDownObserver(slowWorker, numericUpDown);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            slowWorker.SlowMethod();
        }

        /// <summary>
        /// Resets all three form controls to default values
        /// </summary>
        private void resetControls()
        {
            numericUpDown.Value = 0;
            probOutput.Value=0;
            trackBar1.Value = 0;
        }
    }
}
