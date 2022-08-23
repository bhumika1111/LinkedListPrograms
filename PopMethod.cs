using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListNew
{
    /// <summary>
    /// Here We Delete Last Element In The lInked List For E.g-56->30->70 and Getting 56->30 At The Output. 
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
            Console.WriteLine("**Element added in linkedlist is : {0} ", + node.data, "***");
        }

        //Delete Last Element from the Linked List using PopLast Method

        public void popLast()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }

            Node newnode = head;

            while (newnode.Next.Next != null)
            {
                newnode = newnode.Next;
            }
            Node popLast = newnode.Next;
            newnode.Next = null;
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
