using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// The encryption manager
        /// </summary>
        EncryptionEngine manager = new EncryptionEngine();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            //Get string to encrypt
            String input = tbInput.Text;
            //Get encrypted string
            String output = manager.Encrypt(input);
            //Set output on form
            tbOutput.Text = output;
        }

        private void rbROT13_CheckedChanged(object sender, EventArgs e)
        {
            manager.ChangeEngine(1);
        }

        private void rbStringReverse_CheckedChanged(object sender, EventArgs e)
        {
            manager.ChangeEngine(2);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            //Get string to decrypt
            String input = tbInput.Text;
            //Get decrypted string
            String output = manager.Decrypt(input);
            //Set output on form
            tbOutput.Text = output;
        }
    }
}
