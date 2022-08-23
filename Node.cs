using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListNew
{
       public class Node
        {

            public int data;
            public Node Next;

            //constructor of Node class
            public Node(int data)
            {
                this.data = data;
                Next = null;
            }
        }
}
