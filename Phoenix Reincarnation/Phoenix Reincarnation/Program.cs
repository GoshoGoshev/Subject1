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
            double[] a = new double[30];
            double[] b = new double[30];
            for (int i = 0; i < n * 3; i++) a[i] = double.Parse(Console.ReadLine());
            double lengh=0,wid=0,god=0;
            int br = 0,j=0;
            for (int i = 0; i < n * 3; i++)
            {
                br++;
                if (br == 1) lengh = a[i] *a[i];
                if (br == 2) wid = a[i];
                if (br == 3)
                {
                    god = lengh * (wid + 2 * a[i]);
                    b[j] = god;
                    j++;
                    lengh = 1;
                    br = 0;
                    wid = 0;
                    god = 0;
                }
            }
            int l=0;
            for (int k = 0; k < n; k++)
            {
                if (b[k] % 1 != 0) l++;
            }
            if(l>0)for (int k = 0; k < n; k++) Console.WriteLine("{0:f3}", b[k]);
            else for (int k = 0; k < n; k++) Console.WriteLine(b[k]);
        }
    }
}
