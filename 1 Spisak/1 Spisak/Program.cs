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
            var a = new List<int> { };
            for(int i=0;i<n;i++)a.Add(int.Parse(Console.ReadLine()));
            for(int i=0;i<a.Count;i++)if(a[i]%2==0)Console.Write(a[i]+" ");
        }
    }
}
