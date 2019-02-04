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

            var n = int.Parse(Console.ReadLine());
            int S=0;
            for (int i = 0; i < n; i++)
            {
                var a = int.Parse(Console.ReadLine());
                S = S + a;
                if (S > 255) { Console.WriteLine("Insufficient capacity!"); S = S - a; }
            }
            Console.WriteLine(S);
        }
    }
}
