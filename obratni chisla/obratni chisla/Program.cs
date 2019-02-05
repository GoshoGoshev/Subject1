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
            var n=int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++) a[i] = int.Parse(Console.ReadLine());
            for (int j = a.Length-1; j >= 0; j--) Console.WriteLine(a[j]);
        }
    }
}
