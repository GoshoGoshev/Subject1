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
       
            long S = 0;
            long n = 1;

                while (a != 0)
                {
                    S = S + a % 2 * n;
                    n = n * 10;
                    a = a / 2;
                }
                Console.WriteLine(S);
        }
    }
}
