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
            string input, input2, input3, input4;
            int egg, egg2, egg3, egg4, total, dozen, eggs;
            Console.WriteLine("How many eggs did the first chicken lay?");
            input = Console.ReadLine();
            egg = Convert.ToInt32(input);
            Console.WriteLine("How many eggs did the second chicken lay?");
            input2 = Console.ReadLine();
            egg2 = Convert.ToInt32(input2);
            Console.WriteLine("How many eggs did the third chicken lay?");
            input3 = Console.ReadLine();
            egg3 = Convert.ToInt32(input3);
            Console.WriteLine("How many eggs did the fourth chicken lay?");
            input4 = Console.ReadLine();
            egg4 = Convert.ToInt32(input4);
            total = egg + egg2 + egg3 + egg4;
            dozen = total / 12;
            eggs = total % 12;
            Console.WriteLine("A total of {0} eggs is equal to {1} dozens and {2} eggs", input, dozen, eggs);
        }
    }
}
