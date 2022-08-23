using System;

namespace LinkedListNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Output For Element Inserted At a Particular Position Using Insert Method **");
            InsertInBetween insertInBetween = new InsertInBetween();
            insertInBetween.Add(56);
            insertInBetween.Append(70);
            //Creating object of Node class and passing data. 
            //Here 30 is Inserted To The List.
            Node node = new Node(30);
            Console.WriteLine("**Element Inserted In Between ,The List After 56 : {0}", node.data,"**");
            Console.WriteLine("**So After Inserting The Final List Appears As :***");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
            insertInBetween.Insert(56, node);
            insertInBetween.Display();
         
        }
    }
}
