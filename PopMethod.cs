using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListNew
{
    /// <summary>
    /// Here We Delete First Element In The lInked List For E.g-56->30->70 and Getting 30->70 At The Output. 
    /// </summary>
    public class PopMethod
    {

        //head is used as node start point
        Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine("**Element added in linkedlist is : {0} ", +node.data, "***");
        }

        //pop Method to delete First elements from the linked list.

        public void pop()
        {
            if (head == null)
            {
                Console.WriteLine("*linked List is Empty*");
            }
            else
            {
                Node popped = head;
                head = head.Next;

            }
        }

        //Display Method is Used to Display elements.

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("**Linked List is Empty**");
            }
            else
            {
                Console.WriteLine("**Output For Linked List :**");

                Node temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.Next;
                }

            }
        }
    }
}
