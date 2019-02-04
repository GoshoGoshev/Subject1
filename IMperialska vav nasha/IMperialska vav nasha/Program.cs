using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            var b = double.Parse(Console.ReadLine());
            double c;
            if (a == "miles") { c = b * 1.6; Console.WriteLine("{0} miles = {1:f2} kilometres", b, c); }
            if (a == "inches") { c = b * 2.54; Console.WriteLine("{0} inches = {1:f2} santimetres", b, c); }
            if (a == "feet") { c = b * 30; Console.WriteLine("{0} feet = {1:f2} santimetres", b, c); }
            if (a == "yards") { c = b * 0.91; Console.WriteLine("{0} yards = {1:f2} metres", b, c); }
            if (a == "galoons") { c = b * 3.8; Console.WriteLine("{0} galoons = {1:f2} liters", b, c); }
        }
    }
}
