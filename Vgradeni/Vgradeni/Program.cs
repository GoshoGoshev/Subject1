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
            for (int i = 0; i < n; i++) a[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum={0}", a.Sum());
            Console.WriteLine("Min={0}", a.Min());
            Console.WriteLine("Max={0}", a.Max());
            Console.WriteLine("Srednoar={0}", a.Average());
        }
    }
}
