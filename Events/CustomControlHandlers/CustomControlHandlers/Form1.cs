using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControlHandlers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Create random number generator
            Random rng = new Random();

            //Create handlers anonymously with rng
            new CustomHandler(btnTest, rng);
            new CustomHandler(btnTest, rng);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the Form's Handler");
        }
    }
}
