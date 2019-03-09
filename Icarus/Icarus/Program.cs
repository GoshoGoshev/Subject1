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
            int[] a = new int[30];
            a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var st = int.Parse(Console.ReadLine());
            string posoka="st";
            int steps = 0;
            int damage = 1;
            while (posoka != "Supernova")
            {
                string[] b = new string[50];
                 b = Console.ReadLine().Split(' ').ToArray();
                 posoka = b[0];
                  char[] c=b[1].ToCharArray();
                 steps = (int)c[1] - 48;
                 Console.WriteLine(steps);
                if (posoka == "Supernova") break;
                int stepcount = 0;
                if(posoka=="right") for (int i = st; i < a.Length; i++)
                                    {

                                        if (i != st) stepcount++;
                                        if (i != st || i == a.Length - 1) a[i] = a[i] - damage;
                                        if (stepcount == steps) { st = i; break; }
                                        if (a[i] < 0) a[i] = 0;
                                        if (i == a.Length - 1) { i = 0; damage++; }   
                                    }

                if (posoka == "left") for (int i = st; i >= 0; i--)
                    {
                        if(i!=st)stepcount++;
                        if (i != st||i==a.Length-1)a[i] = a[i] - damage;
                        if (stepcount == steps) { st = i; break; }
                        if (a[i] < 0) a[i] = 0;
                        if (i == 0) { i = a.Length-1; damage++; }
                    }

            }
            for (int i = 0; i < a.Length; i++) Console.Write(a[i]+" ");
            Console.WriteLine();
        }
    }
}
