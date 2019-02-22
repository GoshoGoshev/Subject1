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
            int abr = a.Length;
            a.ToCharArray();
            char[] b = new char[a.Length];
            int k=0,br=0;
            for (int i = abr - 1; i >= 0; i--) { b[k] = a[i]; k++; }
            for (int i = 0; i < abr; i++) if (b[i] == a[i]) br++;
            if (br == abr) Console.WriteLine("True");
            else Console.WriteLine("False");
        }
    }
}
