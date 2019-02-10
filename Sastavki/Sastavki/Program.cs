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
            var a = new List<string>();
            for (int i = 0; i < n; i++) a.Add(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            int br=0;
            for (int i = 0; i < n; i++)
            {
                if(a[i].Length==b) Console.WriteLine(a[i]);br++;
                if (br > 10) break;
            }
            

        }
    }
}
