using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predicates
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Random number generator
        /// </summary>
        Random random;
        public Form1()
        {
            InitializeComponent();
            //Init rng
            random = new Random();
        }

        /// <summary>
        /// Generates random numbers for input
        /// </summary>
        /// <param name="sender">Unused</param>
        /// <param name="e">Unused</param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            listboxInput.Items.Clear();
            for (int i = 0; i < 20; i++)
            {
                //Generate number and add to listbox
                int number = random.Next(1,100);
                listboxInput.Items.Add(number);
            }
        }
    }
}
