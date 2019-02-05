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
            for(int i=0;i<a.Length;i++)if(a[i]>='a'&&a[i]<='z')Console.WriteLine("{0}-{1} ",a[i],(int)a[i]-96);

        }
    }
}
