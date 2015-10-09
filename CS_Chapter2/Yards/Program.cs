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
            double length = 25;
            double width = 42;
            double area = (length*width)/ 9 ;
            double price = 5.00;
            string carpetprice;
            carpetprice = price.ToString("F");
            double totalprice = area * price;
            Console.WriteLine("The cost per square yard is ${0}. The cost to carpet this room is ${1}.", carpetprice, totalprice);
        }
    }
}
