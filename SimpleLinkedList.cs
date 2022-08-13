using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.cs
{
    /// <summary>
    /// Here We Are Creating Simple Link List .
    /// </summary>
  public static class SimpleLinkedList
    {
        public static void LinkedlistDisplay()
        {
            List<int> list = new List<int>();
            list.Add(56);
            list.Add(30);
            list.Add(70);

            foreach(int ele in list)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine("Count List Of Elements:" + list.Count);
        } 
    }
}
