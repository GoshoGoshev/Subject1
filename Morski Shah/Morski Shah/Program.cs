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
            char[,] a = new char[3, 3];
            for (int row = 0; row < a.GetLength(0); row++)
            {
                for (int col = 0; col < a.GetLength(1); col++)
                {
                    a[row, col] = char.Parse(Console.ReadLine());
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

            int Xwins = 0, Owins = 0;
            int brx = 0, bro = 0;
            //Diagonal

            for (int row = 0; row < a.GetLength(0); row++)
            {
                for (int col = 0; col < a.GetLength(1); col++)
                {
                    if (row == col && a[row, col] == 'X') brx++;
                    if (row == col && a[row, col] == 'O') bro++;
                }
            }
            if (brx == 3) Xwins = 1;
            if (bro == 3) Owins = 1;

            //Horizontal
            brx = 0; bro = 0;

            for (int row = 0; row < a.GetLength(0); row++)
            {
                for (int col = 0; col < a.GetLength(1); col++)
                {
                    if ( a[row, col] == 'X') brx++;
                    if ( a[row, col] == 'O') bro++;
                    if (brx == 3) Xwins = 1; break;
                    if (bro == 3) Owins = 1; break;
                }
                brx = 0; bro = 0;
            }


            //Vertikal
            brx = 0; bro = 0;

            for (int col = 0; col < a.GetLength(1); col++)
            {
                for (int row = 0; row < a.GetLength(0); row++)
                {
                    if (a[row, col] == 'X') brx++;
                    if (a[row, col] == 'O') bro++;
                    if (brx == 3) Xwins = 1; break;
                    if (bro == 3) Owins = 1; break;
                }
                brx = 0; bro = 0;
            }


            //BackDiagonal
            brx = 0; bro = 0;
            for (int row = 0; row < a.GetLength(0); row++)
            {
                for (int col = a.GetLength(1)-1; col >=0 ; col--)
                {
                    if ( a[row, col] == 'X') brx++;
                    if ( a[row, col] == 'O') bro++;
                    row++;
                }
                break;
            }
            if (brx == 3) Xwins = 1;
            if (bro == 3) Owins = 1;

            //Finale
            if (Xwins == 1) Console.WriteLine("X WINS!!!!");
            if (Owins == 1) Console.WriteLine("O WINS!!!!");
        }
    }
}
