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
                selectedDelegate = new progressDelegate(spinBoxUpdater);
            }
            else if (rbProgressBar.Checked)
            {
                selectedDelegate = new progressDelegate(progressBarUpdater);
            }
            else
            {
                //trackbar
                selectedDelegate = new progressDelegate(trackBarUpdater);
            }

            resetControls();
            slowMethod(selectedDelegate);
        }
        /// <summary>
        /// Updates spin box control
        /// </summary>
        private void spinBoxUpdater()
        {
            //TODO Check this is correct as it might not account for step sizes =/= 1
            numericUpDown.Value++;
        }

        /// <summary>
        /// Updates progress bar control
        /// </summary>
        private void progressBarUpdater()
        {
            probOutput.PerformStep();
        }

        /// <summary>
        /// updates a trackbar control
        /// </summary>
        private void trackBarUpdater()
        {
            //TODO Check this is correct as it might not account for step sizes =/= 1
            trackBar1.Value++;
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
                //TODO Replace this as it makes the UI unresponsive
                System.Threading.Thread.Sleep(500);
                //Increment the given progress diplayer
                myProgressDelegate();
                //Force form to update
                Application.DoEvents();
            }
        }
    }
}
