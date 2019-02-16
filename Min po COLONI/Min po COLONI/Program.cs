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
                for (int col = 0; col < a.GetLength(1); col++)
                {
                    Console.Write(a[row,col]+" ");
                }
                Console.WriteLine();
            }
            int[] ha = new int[a.GetLength(1)];
            int i = 0;
            for (int col = 0; col < a.GetLength(1); col++)
            {
                int min = int.MaxValue;
                for (int row = 0; row < a.GetLength(0); row++)
                {
                    if (a[row, col] < min) min = a[row, col];
                }
                ha[i] = min;
                i++;
            }
            for (int j = 0; j < ha.Length; j++) Console.Write(ha[j]+" ");
            Console.WriteLine();
        }
    }
}
