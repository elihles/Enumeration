using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    internal class Program
    {
        enum Month
        {
            January=1,February,March,April,May,June,July,August,September,October,November,December
        }
        static void Main(string[] args)
        {
            Month month;
            Console.Write("Enter a month Number:");
            int pos=int.Parse(Console.ReadLine());
            month = (Month)pos;
            Console.WriteLine("{0} is month {1}", month, pos);
            Console.ReadLine();
        }
    }
}
