using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates_and_Events
{
    public delegate int operation(int x, int y); // Creation of Delegate
    class  SinglecastDelegate
    {
        public static int Addition (int a, int b) 
        {
            return a + b;
        }
    }
}
