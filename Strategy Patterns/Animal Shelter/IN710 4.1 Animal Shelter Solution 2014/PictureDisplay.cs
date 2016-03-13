using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    class PictureDisplay : IDisplay
    {
        List<PictureBox> pictureBoxList;
        /* YOUR CODE HERE */
        public PictureDisplay(List<PictureBox> pictureBoxList)
        {
            this.pictureBoxList = pictureBoxList;
        }
        public void displayCritterList(List<Critter> critterList)
        {
            //Loop over all the critters and display a picture for each
            for (int i = 0; i < pictureBoxList.Count && i < critterList.Count; i++)
            {
                pictureBoxList[i].ImageLocation = critterList[i].ImageFileName;
            }
        }

        public void clearDisplay()
        {
            foreach (PictureBox pb in pictureBoxList)
            {
                pb.Image = null;
            }
        }
    }
}
