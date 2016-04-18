using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XML
{
    public partial class Form1 : Form
    {
        XMLManager myXMLManager;
        public Form1()
        {
            InitializeComponent();
            myXMLManager = new XMLManager();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create file dialog
            OpenFileDialog ofd = new OpenFileDialog();
            //Set filter options etc
            ofd.Filter = "XML (.xml)|*.xml";

            //Show window
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                String filename = ofd.FileName;

                //TODO Check it is the correct file?

                myXMLManager.openFile(filename);
            }
        }

        private void listUpcomingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clear dgv
            dataGridView1.DataSource=null;
            dataGridView1.Rows.Clear();
            //Grab request
            List<Gig> data = myXMLManager.loadUpcomingGigs();

            dataGridView1.DataSource = data;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hardRockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clear dgv
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            //Grab request
            List<Gig> data = myXMLManager.loadHardRockGigs();

            dataGridView1.DataSource = data;
        }

        private void currentMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clear dgv
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            //Grab request
            List<Gig> data = myXMLManager.loadCurrentMonth();

            dataGridView1.DataSource = data;
        }
    }
}
