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
        /// Delegate for which selection we want
        /// </summary>
        Predicate<int> selectionPredicate;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Generates random numbers for input
        /// </summary>
        /// <param name="sender">Unused</param>
        /// <param name="e">Unused</param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            listboxInput.Items.Clear();
            for (int i = 0; i < 100; i++)
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
            selectionPredicate = new Predicate<int>(isEven);
            process(selectionPredicate);
        }

        private void btnLessThanTen_Click(object sender, EventArgs e)
        {
            selectionPredicate = new Predicate<int>(isLessThanTen);
            process(selectionPredicate);
        }

        private void process(Predicate<int> selectType)
        {
            //Clear list box
            //This was interesting line as lb.Items.Clear() wont work
            listboxOutput.DataSource = null;

            List<int> numberList = new List<int>();

            //Get all items as a list<>
            numberList = listboxInput.Items.Cast<int>().ToList();

            //Get only the items we want
            numberList = numberList.FindAll(selectionPredicate);

            //Output
            listboxOutput.DataSource = numberList;
        }
    }
}