using System;

namespace Linkedlist
{
    //Driver Code
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Output For LinkedList ****");
            Console.WriteLine(":::::::::::::::::::::::::::::::::");
            // Create Object Of Implementing Class.
            LinkedListAdd Linkedlist = new LinkedListAdd();
            //Insert 70 At Staring.
            Linkedlist.Add(70);
            //Inserted 30 To 70.
            Linkedlist.Add(30);
            //Inserted 56 To 30
            Linkedlist.Add(56);
            //Display The Linkedlist.
            Linkedlist.Display();
        }
    }
}
