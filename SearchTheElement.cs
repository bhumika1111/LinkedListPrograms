using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListNew
{
    /// <summary>
    /// Here We Search The LinkedList To Find The Node With Value 30. 
    /// </summary>
    public class SearchTheElement
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

        //Search method

        public Node Search(int data)
        {

            while (head != null)
            {
                if (head.data == data)
                {
                    Console.WriteLine("Searched element is present in linked list : {0}", data);
                }

                head = head.Next;
            }
            return null;
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
