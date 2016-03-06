using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    public class Stack
    {
        /// <summary>
        /// Points to the first Node in the Stack
        /// </summary>
        Node headPointer;
        /// <summary>
        /// Points to the last Node in the Stack
        /// </summary>
        Node tailPointer;

        /// <summary>
        /// Constructor
        /// </summary>
        public Stack()
        {
            //Set headPointer and tailPointer to null(No items in Stack)
            headPointer = tailPointer = null;
        }

        /// <summary>
        /// Push a new item onto the Stack
        /// </summary>
        /// <param name="newString">Item to push onto the Stack</param>
        /// TODO Is a null string allowed or throw an exception?
        public void Push(String newString)
        {
            ///Create the new Node
            Node newNode = new Node(newString);
            //Add the new Node to the list
            //Check if the list is empty
            if (headPointer == null)
            {
                //Set headPointer and tailPointer to the new Node
                headPointer = tailPointer = newNode;
            }
            else
            {
                //Get the last Node and point it's next to the new Node
                tailPointer.Next = newNode;
                //Point tailPointer to the new Node
                tailPointer = newNode;
            }
        }

        /// <summary>
        /// Count how many Nodes are in the Stack
        /// </summary>
        /// <returns>Number of Nodes</returns>
        public int Count()
        {
            //keep track of how many nodes there are
            int count = 0;

            //Start node
            Node nodeWalker = headPointer;

            while (nodeWalker != null)
            {
                count++;
                //Move to the next item in the linked list
                nodeWalker = nodeWalker.Next;
            }
            return count;

        }
    }
}
