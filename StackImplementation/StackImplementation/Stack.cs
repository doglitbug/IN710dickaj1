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

        /// <summary>
        /// Have a look at the last item added to the stack
        /// </summary>
        /// <returns>String of last added to Stack</returns>
        public String Peek()
        {
            String result;

            //Check this is not an empty list
            if (tailPointer == null)
            {
                throw new Exception("Cannot return result for Peek: Stack is empty");
            }

            //Grab last Node in list
            Node lastNode = tailPointer;
            //Grab String from this Node
            result = lastNode.Data;

            return result;
        }

        /// <summary>
        /// Return last item on the Stack and remove it
        /// </summary>
        /// <returns>String of last item added to Stack</returns>
        public String Pop()
        {
            String result;

            //Grab data from last node
            result = Peek();

            //Remove last Node

            //Check if the stack has only one item
            if (headPointer == tailPointer)
            {
                headPointer = tailPointer = null;
            }
            else
            {
                //Prepare to walk list to find previous Node
                Node nodeWalker = headPointer;

                while (nodeWalker.Next != tailPointer)
                {
                    nodeWalker = nodeWalker.Next;
                }
                //Found previous Node
                //Set Next to null as it is now the last Node
                nodeWalker.Next = null;

                //Set tailPointer to last item in list
                tailPointer = nodeWalker;

            }
            return result;
        }

        /// <summary>
        /// Does the stack have zero items on it?
        /// </summary>
        /// <returns>True for zero, false otherwise</returns>
        public Boolean IsEmpty()
        {
            return (headPointer == null);
        }
    }
}
