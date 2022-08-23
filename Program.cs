using System;

namespace LinkedListNew
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("**Output For Search  Particular Element using Search Method from the List**");
            Console.WriteLine("Adding Elements as follows :");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
            SearchTheElement search = new SearchTheElement();
            search.Add(56);
            search.Add(30);
            search.Add(70);
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
            search.Display();
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("After searching for a Particular Element ");
            search.Search(30);

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
            

        }
    }
}
