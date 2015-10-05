using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yards
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = 10.5;
            double width = 25.5;
            double area = (length / 3) * (width / 3);
            double price = 5.00;
            string carpetprice;
            carpetprice = price.ToString("F");
            double totalprice = area * price;
            Console.WriteLine("The cost per square yard is ${0}. The cost to carpet this room is ${1}.", carpetprice, totalprice);
        }
    }
}
