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
        /// <summary>
        /// Reference to the picture boxes from the form
        /// </summary>
        List<PictureBox> pictureBoxList;
        public PictureDisplay(List<PictureBox> pictureBoxList)
        {
            this.pictureBoxList = pictureBoxList;
        }
        /// <summary>
        /// Display pictures for the given critterList
        /// </summary>
        /// <param name="critterList">List of critters</param>
        public void displayCritterList(List<Critter> critterList)
        {
            //Loop over all the critters and display a picture for each
            //Double condition in for loop so that less critters than pictureboxes can be displayed
            for (int i = 0; i < pictureBoxList.Count && i < critterList.Count; i++)
            {
                //Set picture box image to that of critter
                pictureBoxList[i].ImageLocation = critterList[i].ImageFileName;
            }
        }

        /// <summary>
        /// Clear all picture boxes
        /// </summary>
        public void clearDisplay()
        {
            //Loop over each picture box and set image to null
            foreach (PictureBox pb in pictureBoxList)
            {
                pb.Image = null;
            }
        }
    }
}
