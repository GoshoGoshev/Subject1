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
            double S=0;
            int n=0;
            double Step;
            while (a != 0)
            { 
                Step=Math.Pow(2,n);
                S = S + a % 10 * Step;
                a = a / 10;
                n = n+1;
            }
            Console.WriteLine(S);


        }
    }
}
