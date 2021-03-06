﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Animal_Noises
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Thread to hold Animal.speak
        /// </summary>
        Thread t;
        public Form1()
        {
            InitializeComponent();
        }

        private Animal mainAnimal;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create new Animal
            mainAnimal = new Animal();
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            //Create thread if needed
            if (t == null)
            {
                t = new Thread(mainAnimal.speak);
                //Start the thread
                t.Start();
            }
        }

        private void btnWhat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It is a frog");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //Request killing off the thread is it is running
            if (t != null)
            {
                t.Abort();
                t = null;
            }
        }


    }
}
