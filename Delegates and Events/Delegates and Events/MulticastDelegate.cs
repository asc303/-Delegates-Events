using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates_and_Events
{
    class MulticastDelegate
    {
        delegate void DelOp(int x, int y); // Creating  of Delegation Operation
        public static void ImplementDelegate()
        {
            DelOp obj = Operation.Add;
            obj += Operation.Square;

            obj(6, 6);
            obj(8, 5);
            Console.ReadLine();
        }
        public class Operation // Creating of Operation Class
        {
            public static void Add(int a, int b)
            {
                Console.WriteLine("Addition = {0}", a + b);
            }
            public static void Square(int a, int b)
            {
                Console.WriteLine("Multiple = {0}", a * b);
            }
        }
    }
}
