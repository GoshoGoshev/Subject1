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
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("years: "+a*100);
            Console.WriteLine("dni: " + a*100*365.2422);
            Console.WriteLine("chasove: " + a*100*365.2422*24);
            Console.WriteLine("minuti: " + a * 100 * 365.2422 * 24*60);
        }
    }
}
