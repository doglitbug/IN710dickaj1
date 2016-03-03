using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace RainbowChicken2016
{
    public class PelletList
    {
        Pellet headPointer = null;
        Pellet tailPointer = null;

        Rectangle boundsRectangle;

        //==============================================================================
        // Ctor
        //==============================================================================
        public PelletList(Rectangle boundsRectangle)
        {
            this.boundsRectangle = boundsRectangle;
        }

        //==============================================================================
        // Add Pellet newPellet at the end of the list.
        //==============================================================================
        public void addPellet(Pellet newPellet)
        {
            //Check if the list is empty
            if (headPointer == null)
            {
                //Set head and tail to point to the new pellet
                headPointer = newPellet;
                tailPointer = newPellet;
            }
            else
            {
                //Get last item and point its next to the new pellet
                tailPointer.Next = newPellet;
                //Point tailPointer to the new pellet
                tailPointer = newPellet;
            }
        }

        //==============================================================================
        // Walk the list, counting the number of Pellet. Return the count.
        //==============================================================================
        public int Count()
        {
            //Keep track of how many nodes have been counted so far
            int count = 0;
            //Start pellet
            Pellet pelletWalker = headPointer;

            while (pelletWalker != null)
            {
                count++;
                //Move to the next item in the linked list
                pelletWalker = pelletWalker.Next;
            }
            return count;
        }

        //==============================================================================
        // Walk the list, calling the Move() method of each Pellet
        //==============================================================================
        public void Move()
        {
            //Start pellet
            Pellet pelletWalker = headPointer;

            while (pelletWalker != null)
            {
                //Call the pellets move method
                pelletWalker.Move();
                //Move to the next item in the linked list
                pelletWalker = pelletWalker.Next;
            }
        }

        //==============================================================================
        // Walk the list. For each Pellet, call TestOutOfBounds, passing boundsRectangle.
        // For each node that is out of bounds, set its IsAlive property to false.
        //==============================================================================
        public void KillOutOfBounds()
        {
            //Start pellet
            Pellet pelletWalker = headPointer;

            while (pelletWalker != null)
            {
                //Check if pellet is out of bounds and kill if so
                pelletWalker.IsAlive=pelletWalker.TestOutOfBounds(boundsRectangle);
                //Move to the next item in the linked list
                pelletWalker = pelletWalker.Next;
            }
        }

        //==============================================================================
        // Delete the argument Pellet pelletToDelete from the list.
        // Be careful to maintain the integrity of the list, including
        // headPointer and tailPointer.
        //==============================================================================
        public void DeleteOne(Pellet pelletToDelete)
        {
            //Check if this is the first node in the list
            if (headPointer == pelletToDelete)
            {
                //Check if it is the only node in the list
                if (tailPointer == pelletToDelete)
                {
                    headPointer = tailPointer = null;
                }
                else
                {
                    headPointer = pelletToDelete.Next;
                }
            }
            else
            {
                //Prepare to walk the list
                Pellet pelletWalker = headPointer;

                //Find the pellet before pelletToDelete
                while (pelletWalker.Next != pelletToDelete)
                {
                    pelletWalker = pelletWalker.Next;
                }
                //Found previous pellet, swoop around
                pelletWalker.Next = pelletToDelete.Next;

                //Check this wasn't the last node in the list
                if (tailPointer == null)
                {
                    tailPointer = pelletWalker;
                }
            }
        }

        //==============================================================================
        // Walk the list, deleting all nodes whose IsAlive propoerty is false
        //==============================================================================
        public void DeleteNotAlive()
        {
            //Start pellet
            Pellet pelletWalker = headPointer;

            while (pelletWalker != null)
            {
                //Check if pellet needs to be removed and call method to do so
                if (pelletWalker.IsAlive != true)
                {
                    DeleteOne(pelletWalker);
                }
                //Move to the next item in the linked list
                pelletWalker = pelletWalker.Next;
            }
        }

        //==============================================================================
        // Walk the list, calling each node's Draw method
        //==============================================================================
        public void Draw()
        {
            //Start pellet
            Pellet pelletWalker = headPointer;

            while (pelletWalker != null)
            {
                //Check if pellet is out of bounds and kill if so
                pelletWalker.Draw();
                //Move to the next item in the linked list
                pelletWalker = pelletWalker.Next;
            }
        }
    }
}
