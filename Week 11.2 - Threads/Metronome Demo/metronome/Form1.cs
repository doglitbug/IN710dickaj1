using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;



namespace metronome
{
    public partial class Form1 : Form
    {
        private Metronome mainMetronome;
        private Beeper mainBeeper;
        private Counter mainCounter;
        private TimeDisplay mainTimeDisplay;
        private Thread mainMetronomeThread;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainMetronome = new Metronome(1000, this);
            //Create Thread
            mainMetronomeThread = new Thread(mainMetronome.start);


            mainBeeper = new Beeper(mainMetronome, "blip1.wav");
            mainCounter = new Counter(mainMetronome, numericUpDown1);
            mainTimeDisplay = new TimeDisplay(mainMetronome, listBox1);    
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int currInterval = Convert.ToInt16(textBox1.Text);
           mainMetronome.Interval = currInterval;
           //Start thread if needed(stops user starting multiple metronomes...)
           //TODO Check additional state so that metronome can be started again after Abort?
           if (mainMetronomeThread.ThreadState==ThreadState.Unstarted)
           {
               mainMetronomeThread.Start();
           }
        }

        public void clearBuffer()
        {
            Application.DoEvents();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Code needed here to stop the metronome
        }

    }
}
