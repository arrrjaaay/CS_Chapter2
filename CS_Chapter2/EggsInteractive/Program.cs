using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EggsInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int total, dozen, eggs;
            Console.WriteLine("How many eggs did they lay?");
            input = Console.ReadLine();
            total = Convert.ToInt32(input);
            dozen = total / 12;
            eggs = total % 12;
            Console.WriteLine("A total of {0} eggs is equal to {1} dozens and {2} eggs", input, dozen, eggs);
        }
    }
}
