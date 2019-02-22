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
            var b = Console.ReadLine();
            int abr = a.Length;
            int bbr = b.Length;
            a.ToCharArray();
            b.ToCharArray();
            int S=0;
            if (abr >= bbr) for (int i = 0; i < abr; i++)
                {
                    if (i < bbr) S = S + (int)a[i] * (int)b[i];
                    else S = S + (int)a[i];
                }

            if (bbr > abr) for (int i = 0; i < bbr; i++)
                {
                    if (i < abr) S = S + (int)a[i] * (int)b[i];
                    else S = S + (int)b[i];
                }
            Console.WriteLine(S);
        }
    }
}
