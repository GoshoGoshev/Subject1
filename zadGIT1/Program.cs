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
          

            Console.WriteLine("Godini=" + a*100);
            Console.WriteLine("Dni=" + a * 100*365);
            Console.WriteLine("Chasove=" + a * 100 * 365*24);
            Console.WriteLine("Minuti=" + a * 100 * 365 * 24*60);
           
        }
    }
}
