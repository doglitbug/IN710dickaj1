using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BITAssignments
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Global variable to hold database manager
        /// </summary>
        DatabaseManager db;
        public Form1()
        {
            InitializeComponent();
            //Initialize new database manager
            db = new DatabaseManager();
        }

        /// <summary>
        /// Button click handler to create new database and populate with seed data
        /// </summary>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            db.createSchema();//TODO Delete button and move this to form load?
        }

        /// <summary>
        /// Button click handler to get report for all papers
        /// </summary>
        private void btnListAllPapers_Click(object sender, EventArgs e)
        {
            //Clear previous results
            listBox1.DataSource = null;
            //Get next report
            listBox1.DataSource = db.reportAllPapers();
        }

        /// <summary>
        /// Button click handler to get report for assignments due in next 2 weeks
        /// </summary>
        private void btnListAssignmentsDue_Click(object sender, EventArgs e)
        {
            //Clear previous results
            listBox1.DataSource = null;
            //Get next report
            listBox1.DataSource = db.reportAssignmentsDue();
        }

        /// <summary>
        /// Button click handler to get report for average marks sofar for each paper
        /// </summary>
        private void btnAverageMarksSoFar_Click(object sender, EventArgs e)
        {
            //Clear previous results
            listBox1.DataSource = null;
            //Get next report
            listBox1.DataSource = db.reportAverageMarksSoFar();
        }
    }
}
