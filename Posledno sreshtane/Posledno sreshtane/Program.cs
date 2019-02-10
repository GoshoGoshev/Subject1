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
            var a = new int[n];
            for (int i = 0; i < n; i++) a[i] = int.Parse(Console.ReadLine());
            var b=int.Parse(Console.ReadLine());
            int pom=0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] == b) pom = i;
            }
            int S=0;
            for (int i = 0; i < pom; i++) S = S + a[i];
            Console.WriteLine(S);
        }
    }
}
