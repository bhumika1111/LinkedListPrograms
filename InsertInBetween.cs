using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListNew
{
    /// <summary>
    /// Here We Check The Data Is Inserted In Between ,E.g- To Insert 30 In Between 56 and 70 And Getting As Ouput-56->30->70. 
    /// </summary>
    class InsertInBetween
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
            Console.WriteLine("**Element added in linkedlist is : {0} ", +node.data ,"***");
        }

        //Append Method is used to Add Elements at last

        public void Append(int data)
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
            Console.WriteLine("**After Appending element to lastly added element  : {0}**", data);
        }


        //Insert method takes two parameters to insert element in between the Node

        public void Insert(int lastNode, Node NewData)
        {
            Node temp = head;

            //while loop to check if our temp is null then it return head
            //else it goes to another while loop

            while (temp != null)
            {
                while (temp.data == lastNode)
                {

                    Node newnode = temp.Next;
                    //store NewData to temp.Next

                    temp.Next = NewData;

                    temp.Next.Next = newnode;
                    break;
                }
                temp = temp.Next;
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
