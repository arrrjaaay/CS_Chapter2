using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoursAndMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int jobtime = 70;
            int hours = jobtime / 60;
            int minutes = jobtime % 60;
            Console.WriteLine("{0} hours and {1} minutes", hours, minutes);
        }
    }
}
