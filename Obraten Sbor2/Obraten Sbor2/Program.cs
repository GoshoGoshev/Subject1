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
            var a=new int[n];
            for (int i = 0; i < n; i++) a[i] = int.Parse(Console.ReadLine());

            int c,b=0,S=0,pom=0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] >= 10 && a[i] < 100) pom = 10;
                if (a[i] >= 100 && a[i] < 1000) pom = 100;
                if (a[i] >= 1000 && a[i] < 10000) pom = 1000;
                if (a[i] >= 10000 && a[i] < 100000) pom = 10000;
                while (a[i] != 0)
                {
                    c = a[i] % 10;
                    b = b + c * pom;
                    a[i] = a[i] / 10;
                    pom = pom / 10;
                }
                S = S + b; Console.Write(b+" ");
                b = 0;
            }
            Console.WriteLine();
            Console.WriteLine(S);

        }
    }
}
