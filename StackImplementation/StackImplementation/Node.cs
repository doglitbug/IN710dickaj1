using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    class Node
    {
        public String Data { get; set;}
        public Node Next { get; set;}
        public Node(String data)
        {
            Data = data;
            Next = null;
        }
    }
}
