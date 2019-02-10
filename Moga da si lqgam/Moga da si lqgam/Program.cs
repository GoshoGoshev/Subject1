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
            var a = new List<int>();
            var c = new List<int>();
            for (int i = 0; i < n; i++) a.Add(int.Parse(Console.ReadLine()));
            int br = 0, b = 0;
            for (int k = 0; k < a.Count; k++)
            {
                br = 0;
                for (int j = b; j < a.Count; j++)
                {
                    if (a[k] != a[j]) break;
                    else { br++; }
                }
                c.Add(br);
                b = b + br;
                k = k + br - 1;

            }
            int max = int.MinValue;
            int indeks = 0;
            for (int l = 0; l < c.Count; l++) if (c[l] > max) { max = c[l]; indeks++; }
            int pom;
            if (indeks == 1) pom = indeks - 1;
            else pom = indeks;
            for (int p = 0; p < max; p++) { Console.Write(a[pom] + " "); pom++; }
            Console.WriteLine();
        }
    }
}
