﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace metronome
{
    public class MetronomeObserver
    {
        protected Metronome metronome;
        protected delegate void setCallBack(object sender, metronomeEventArgs e);

        public MetronomeObserver(Metronome metronome)
        {
            this.metronome = metronome;
            metronome.metronomeEvent += new Metronome.metronomeEventHandler(onMetronomeEvent);
        }

        public virtual void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            MessageBox.Show("My metronome clicked");
        }

    }

    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class Beeper : MetronomeObserver
    {
        private String soundFileName;
        private SoundPlayer soundPlayer;

        public Beeper(Metronome metronome, String soundFileName)
            : base(metronome)
        {
            this.soundFileName = soundFileName;
            soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = soundFileName;
        }


        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            soundPlayer.Play();
        }

    } // end TBeeper
    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class Counter : MetronomeObserver
    {
        private NumericUpDown spinBox;

        public Counter(Metronome metronome, NumericUpDown spinBox)
            : base(metronome)
        {
            this.spinBox = spinBox;
        }

        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            if (spinBox.InvokeRequired)
            {
                //Set call back
                setCallBack d = new setCallBack(onMetronomeEvent);
                //Let spinBox know what we want to do
                spinBox.Invoke(d, new object[] {sender,e});
            }
            else
            {
                spinBox.Value++;
            }
        }
    } // end TCounter

    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class TimeDisplay : MetronomeObserver
    {
        private ListBox listBox;

        public TimeDisplay(Metronome metronome, ListBox listBox)
            : base(metronome)
        {
            this.listBox = listBox;
        }

        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            DateTime currDateTime = e.currentTime;

            if (listBox.InvokeRequired)
            {
                //Set call back
                setCallBack d = new setCallBack(onMetronomeEvent);
                listBox.Invoke(d, new object[] { sender, e });
            }
            else
            {
                listBox.Items.Add(currDateTime.ToString());
            }
        }
    }






            
}
