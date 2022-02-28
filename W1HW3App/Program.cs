using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1HW3App
{
    internal class DayPrinter
    {
        static void Main(string[] args)
        {
            String[] days = { "Enter Year:", "2000", "2000 is a leap Year." };
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }
        }
    }
}
