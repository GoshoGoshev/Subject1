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
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            int[,] a = new int[b, c];
            for (int row = 0; row < a.GetLength(0); row++)
            {

                for (int col = 0; col < a.GetLength(1); col++)
                {
                    a[row, col] = int.Parse(Console.ReadLine());
                }
            }
            
            for (int row = 0; row < a.GetLength(0); row++)
            {
                double sr=0;
                for (int col = 0; col < a.GetLength(1); col++)
                {
                    sr = sr + a[row, col];
                   Console.Write(a[row, col]+" "); 
                }
                Console.Write(sr/a.GetLength(1));Console.WriteLine();
            }
        }
            
    }
}
