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
            for (int i = 0; i < n; i++) a.Add(int.Parse(Console.ReadLine()));
            int min=int.MaxValue;
            int max=int.MinValue;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > max) max = a[i];
                if (a[i] < min) min = a[i];
            }
            for (int i = 0; i < n; i++) if(a[i]==min)Console.Write(a[i]+" ");
            if(min!=max)for (int i = 0; i < n; i++) if (a[i] == max) Console.Write(a[i] + " ");
            Console.WriteLine();
        }
    }
}
