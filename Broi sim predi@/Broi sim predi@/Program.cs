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
            int sz = a.Length;
            a.ToCharArray();
            int brpr = 0;
            int krai=0;
            for(int i=0;i<sz;i++)
            {
                brpr++;
                if (a[i] == '@') krai = brpr;
                }
            if (brpr < 2 * krai) Console.WriteLine("Call her!");
            else Console.WriteLine("She is not the one D:");

        }
    }
}
