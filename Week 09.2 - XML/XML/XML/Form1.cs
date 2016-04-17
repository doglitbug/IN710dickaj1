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
        public Form1()
        {
            InitializeComponent();
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
                //TODO pass filename to XML Manager
                MessageBox.Show(filename);
            }
        }
    }
}
