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
            int[] b = new int[n];
            int br=0,k=0;
            for (int i = 0; i < a.Length; i++) a[i] = int.Parse(Console.ReadLine());
            for(int i=0;i<a.Length;i++)
            {
                for (int j = 0; j < a.Length; j++) if (a[i] == a[j]) br++;
                b[k] = br;
                k++;
                br = 0;
            }
            int max=int.MinValue;
            int maxind=0;
            for (int l = 0; l < a.Length; l++)
            {
                if (b[l] > max) { max = b[l]; maxind = l; }
                if (l == a.Length - 1) Console.WriteLine(a[maxind]);
            }
            

        }
    }
}
