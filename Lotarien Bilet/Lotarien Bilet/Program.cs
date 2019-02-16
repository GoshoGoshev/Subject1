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
            var m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
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

            //Sbor na GlavenDiagonal
            int SbGLAVD = 0; int SbCHETNIglavD = 0;
            for (int row = 0; row < a.GetLength(0); row++)
            {
                for (int col = 0; col < a.GetLength(1); col++)
                {
                   if(row==col)SbGLAVD=SbGLAVD+a[row,col];
                    if(row==col&&a[row,col]%2==0)SbCHETNIglavD=SbCHETNIglavD+a[row,col];
                }
            }


            //Sbor na VtorichenDiagonal
            int SbVTRD = 0;
            for (int row = 0; row < a.GetLength(0); row++)
            {
                for (int col = a.GetLength(1)-1; col >=0 ; col--)
                {
                    SbVTRD = SbVTRD + a[row, col];
                    row++;
                }
                break;
            }
           

            //Suma na EL NAD glavniq diagonal
            int SbNAD = 0;
            for (int col = 0; col < a.GetLength(1); col++)
            {
                for (int row = 0; row < a.GetLength(0); row++)
                {
                    if (row == col) break;
                    else SbNAD = SbNAD + a[row, col];
                }
            }
            

            //Suma na EL POD glavniq diagonal
            int SbPOD = 0; 
            for (int row = 0; row < a.GetLength(0);row++ )
            {
                for (int col = 0; col < a.GetLength(1);col++ )
                {
                    if (row == col) break;
                    else SbPOD = SbPOD + a[row, col];
                }
            }

            //Suma CHETNI v KRAINITE REDOVE
            int SchetKRAI=0;
            for (int row = 0; row < a.GetLength(0); row++)
            {
                for (int col = 0; col < a.GetLength(1); col++)
                {
                    if (row == 0 || row == a.GetLength(0) - 1)if(a[row,col]%2==0) SchetKRAI = SchetKRAI + a[row, col];
                }
            }

            //Suma Nechetni v KRAINITE KOLONI
            int NechetKRAI = 0;
            for (int row = 0; row < a.GetLength(0); row++)
            {
                for (int col = 0; col < a.GetLength(1); col++)
                {
                    if (col == 0 ||col == a.GetLength(1) - 1) if (a[row, col] % 2 == 1) NechetKRAI = NechetKRAI + a[row, col];
                }
            }
            Console.WriteLine(NechetKRAI);
            


            int Win=0;
            if (SbGLAVD == SbVTRD&& SbNAD % 2 ==0 &&SbPOD % 2 == 1) {Win=1;Console.WriteLine("YES!!!!");}
       
            //Pechalbi
            double MSUM=0;
            if (Win==1)
            {
                MSUM=(SbPOD+SbCHETNIglavD+SchetKRAI+NechetKRAI)/4;
            }
            Console.WriteLine("0:{f2}", MSUM);



        }
    }
}
