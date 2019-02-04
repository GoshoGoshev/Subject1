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
            var d = Convert.ToString(a, 16);
            Console.WriteLine(d.ToUpper());
        }
    }
}
