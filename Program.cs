using System;

namespace LinkedListNew
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("**Output For First Element Deleted from the list using pop Method**"); 
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("Adding Elements as follows :");
            PopMethod popMethod = new PopMethod();
            popMethod.Add(56);
            popMethod.Add(30);
            popMethod.Add(70);
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
            popMethod.Display();
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("**Element Popped out from the list**");
            popMethod.pop();
            popMethod.Display();
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
            

        }
    }
}
