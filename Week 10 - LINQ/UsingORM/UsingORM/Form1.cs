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
        DatabaseManager dbm;
        public Form1()
        {
            InitializeComponent();
            dbm = new DatabaseManager();
        }

        private void btnAveIntensity_Click(object sender, EventArgs e)
        {
            listBox1.DataSource=null;
            listBox1.DataSource = dbm.getAverageIntensty();
        }

        private void btnThreelargestFires_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = dbm.getThreeLargestFires();
        }
    }
}
