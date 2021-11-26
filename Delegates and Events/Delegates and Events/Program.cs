using System;

namespace Delegates_and_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            operation obj = new operation(SinglecastDelegate.Addition); // Object Creating  For Single Delegate
            Console.WriteLine("Addition is: {0}", obj(25, 25));
            MulticastDelegate.ImplementDelegate(); // Directly Call of a Function Using Class
            Events.ImplementEvent(); 
        }
    }
}