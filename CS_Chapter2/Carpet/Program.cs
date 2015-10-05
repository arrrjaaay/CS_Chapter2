using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carpet
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = 10.5;
            double width = 25.5;
            double area = length * width;
            double price = 2.50;
            string carpetprice;
            carpetprice = price.ToString("F");
            double totalprice = area * price;
            Console.WriteLine("The cost per square foot is ${0}. The cost to carpet this room is ${1}.", carpetprice, totalprice);
        }
    }
}
