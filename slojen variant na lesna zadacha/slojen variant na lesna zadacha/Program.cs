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
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++) a[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < a.Length; i++)
            {
                if (a.Length - i-1  - i == 2) { Console.WriteLine("{ " + a[i] + " , " + a[i+1] + " , " + a[i+2] + " }"); break; }
                if (a.Length - i -1 - i == 3) { Console.WriteLine("{ " + a[i+1] + " , " + a[i+2] + " }"); break; }
                if (a.Length - i -1 - i == 1) { Console.WriteLine("{ " + a[i+1] + " }"); break; }
            }
        }
    }
}
