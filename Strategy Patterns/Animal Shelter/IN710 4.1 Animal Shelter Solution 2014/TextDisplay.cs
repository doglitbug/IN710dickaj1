using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    class TextDisplay: IDisplay
    {
        /* YOUR CODE HERE */
        ListBox theListBox;
        public TextDisplay(ListBox theListBox)
        {
            this.theListBox = theListBox;
        }
        public void displayCritterList(List<Critter> critterList)
        {
            foreach (Critter c in critterList)
            {
                theListBox.Items.Add(c);
            }
        }

        /// <summary>
        /// Clear the display
        /// </summary>
        public void clearDisplay()
        {
            theListBox.Items.Clear();
        }
    }
}
