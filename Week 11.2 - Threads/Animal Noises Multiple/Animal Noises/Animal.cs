using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;

namespace Animal_Noises
{
    public class Animal
    {
        private SoundPlayer soundPlayer;
        private String soundFileName;
        SharedAccess sharedAccess;

        public Animal(String soundFileName, SharedAccess sharedAccess)
        {
            soundPlayer = new SoundPlayer(soundFileName);
            this.sharedAccess = sharedAccess;
        }

        public void speak()
        {
            while (true)
            {
                //Lock object so that all threads don't try playing at once
                lock (sharedAccess)
                {
                    soundPlayer.Play();
                    Thread.Sleep(500);
                }
            }
        }

    }

    /// <summary>
    /// Used to lock usage of the soundPlayer by Animal Threads
    /// </summary>
    public class SharedAccess {}
    
}
