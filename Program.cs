using System;

namespace Linkedlist
{
    //Driver Code
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Output For LinkedList Append ****");
            Console.WriteLine(":::::::::::::::::::::::::::::::::");
            // Create Object Of Implementing Class.
            LinkedListAppend Linkedlist = new LinkedListAppend();
            //Insert 56 At Staring.
            Linkedlist.Add(56);
            //Append 30 To 56.
            Linkedlist.Append(30);
            //Append 70 To 30.
            Linkedlist.Append(70);

          //Display The Linkedlist.
            Linkedlist.Display();
        }
    }
}
