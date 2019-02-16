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
            int SumEVE = 0, SumDr = 0,c;
            while (a != 0)
            {
                c = a % 10;
                if (c % 2 == 0) SumEVE = SumEVE + c;
                else SumDr = SumDr + c;
                a = a / 10;
            }
            Console.WriteLine(SumDr*SumEVE);

        }
    }
}
