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
        public delegate void progressDelegate();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            progressDelegate selectedDelegate;
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

            resetControls();
            slowMethod(selectedDelegate);
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
        /// <summary>
        /// Show progress from 0-100% in 10% steps
        /// </summary>
        /// <param name="myProgressDelegate">Delegate to run for each 10% of progress</param>
        private void slowMethod(progressDelegate myProgressDelegate)
        {
            for (int i = 0; i < 10; i++)
            {
                //Wait for a bit so progress is visible
                System.Threading.Thread.Sleep(1000);
                //Increment and display some progress
                myProgressDelegate();
            }
        }
    }
}
