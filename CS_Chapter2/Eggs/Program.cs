using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch1 = 40;
            int ch2 = 45;
            int ch3 = 42;
            int ch4 = 50;
            int total = ch1 + ch2 + ch3 + ch4;
            int dozen = total / 12;
            int eggs = total % 12;
            Console.WriteLine("A total of {0} eggs is equal to {1} dozens and {2} eggs", total, dozen, eggs);
        }
    }
}
