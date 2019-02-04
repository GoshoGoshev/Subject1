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
            char z1='a',z2='a',z3='a';
            for (int i = 1; i <= n; i++)
            { 
                for (int j = 1; j <= n; j++)
                {
                    
                    for (int k = 1; k <= n; k++)
                    {
                       
                        Console.Write(z1);
                        Console.Write(z2);
                        Console.Write(z3);
                        Console.WriteLine();
                        z3++; if (k == n) z3 = 'a';
                    }
                    z2++;if (j == n) z2 = 'a';
                }
                 z1++;
            }
        }
    }
}
