using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingORM
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Global instance of database manager
        /// </summary>
        DatabaseManager dbm;
        public Form1()
        {
            InitializeComponent();
            //Initalize database manager
            dbm = new DatabaseManager();
        }

        /// <summary>
        /// Button click handler for average intensity
        /// </summary>
        private void btnAveIntensity_Click(object sender, EventArgs e)
        {
            //Clear previous data
            listBox1.DataSource=null;
            //Ask database manager for average intensity and display
            listBox1.DataSource = dbm.getAverageIntensty();
        }

        /// <summary>
        /// Button click handler for three largest fires
        /// </summary>
        private void btnThreelargestFires_Click(object sender, EventArgs e)
        {
            //Clear previous data
            listBox1.DataSource = null;
            //Ask database manager for three largest fires and display
            listBox1.DataSource = dbm.getThreeLargestFires();
        }

        /// <summary>
        /// Button click handler for location and filename of each picture
        /// </summary>
        private void btnLocationPicture_Click(object sender, EventArgs e)
        {
            //Clear previous data
            listBox1.DataSource = null;
            //Ask database manager for location and filename for each picture and display
            listBox1.DataSource = dbm.getLocationPicture();
        }
    }
}
