using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    class Program
    {
        enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
        enum Month : byte { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };
        static void Main(string[] args)
        {
            Day today = Day.Monday;
            int dayNumber = (int)today;
            Console.WriteLine("{0} is day number #{1}.", today, dayNumber);

            Month thisMonth = Month.Dec;
            byte monthNumber = (byte)thisMonth;
            Console.WriteLine("{0} is month number #{1}.", thisMonth, monthNumber);
            Console.ReadKey();
            // Output:
            // Monday is day number #1.
            // Dec is month number #11.
        }
    }
}
