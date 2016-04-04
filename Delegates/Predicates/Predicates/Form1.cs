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

        Predicate<int> selectionPredicate;
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

        /// <summary>
        /// Checks is the given number is even
        /// </summary>
        /// <param name="number">Number to check</param>
        /// <returns>True if even</returns>
        private bool isEven(int number)
        {
            return (number % 2 == 0);
        }

        /// <summary>
        /// Checks if the given number is less than 10
        /// </summary>
        /// <param name="number">Number to check</param>
        /// <returns>True if less than 10</returns>
        private bool isLessThanTen(int number)
        {
            return (number < 10);
        }

        private void btnEven_Click(object sender, EventArgs e)
        {
            List<int> masterList=new List<int>();
            List<int> editedList = new List<int>();

            selectionPredicate = new Predicate<int>(isEven);

            //Get all items
            masterList=listboxInput.Items.Cast<int>().ToList();
            //get only the items we want
            editedList=masterList.FindAll(selectionPredicate);
            //Output
            listboxOutput.DataSource = editedList;
        }

        private void btnLessThanTen_Click(object sender, EventArgs e)
        {
            selectionPredicate = new Predicate<int>(isLessThanTen);
        }

       
    }
}
