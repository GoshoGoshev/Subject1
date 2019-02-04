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
            var c = int.Parse(Console.ReadLine());
            int S=0;
            for (int i = 0; i < c; i++)
            {
                var a = int.Parse(Console.ReadLine());
                var b = int.Parse(Console.ReadLine());
                S = S + a % b;
            }
            Console.WriteLine("Sum ot ostatuci:" + S);
        }
    }
}
