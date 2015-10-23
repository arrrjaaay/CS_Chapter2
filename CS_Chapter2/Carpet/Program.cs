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
            double length = 10.25;
            double width = 25.5;
            double area = length * width;

            double price = 2.50;
            string carpetprice;
            carpetprice = price.ToString("C");

            double totalprice = area * price;
            string total;
            total = totalprice.ToString("C");
            
            Console.WriteLine("The cost per square foot is {0}. The cost to carpet this room is {1}.", carpetprice, total);
        }
    }
}
