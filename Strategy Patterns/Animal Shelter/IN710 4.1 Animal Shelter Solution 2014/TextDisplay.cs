using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    class TextDisplay : IDisplay
    {
        /// <summary>
        /// ListBox to display names into
        /// </summary>
        ListBox theListBox;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="theListBox">Reference to listBox to display items in</param>
        public TextDisplay(ListBox theListBox)
        {
            this.theListBox = theListBox;
        }
        /// <summary>
        /// Display the list of critters given in the listbox
        /// </summary>
        /// <param name="critterList">List of critters</param>
        public void displayCritterList(List<Critter> critterList)
        {
            //Loop over each critter in ther list and add to listbox
            foreach (Critter c in critterList)
            {
                theListBox.Items.Add(c.Name);
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
