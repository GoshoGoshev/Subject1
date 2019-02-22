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
            var n = int.Parse(Console.ReadLine());double MegaS=0;
            for (int k = 0; k < n; k++)
            {
                var a = Console.ReadLine();
                a.ToCharArray();
                int br = 0;
                for (int i = 1; i < a.Length; i++) if ((int)a[i] >= 49 && (int)a[i] < 58) br++;
                int Sch = 0;
                if (br > 1)
                {
                    int c = 0;
                    for (int j = 1; j <= br; j++)
                    {
                        c = (int)a[j] - 48;
                        if (j != 1) Sch = Sch * 10 + c;
                        if (j == 1) Sch = Sch + c;
                    }
                }

                double S = 0;
                char b = 'A';
                if ((int)a[0] >= 65 && (int)a[0] < 97) for (int i = 1; i < 27; i++) { if (a[0] == b) S = Sch / i; b++; }
                b = 'a';
                if ((int)a[0] >= 97 && (int)a[0] < 123) for (int i = 1; i < 27; i++) { if (a[0] == b) S = Sch * i; b++; }
                b = 'A';
                if ((int)a[br + 1] >= 65 && (int)a[br + 1] < 97) for (int i = 1; i < 27; i++) { if (a[br + 1] == b) S = S - i; b++; }
                b = 'a';
                if ((int)a[br + 1] >= 97 && (int)a[br + 1] < 123) for (int i = 1; i < 27; i++) { if (a[br + 1] == b) S = S + i; b++; }
                 MegaS= MegaS + S;
                   
            } Console.WriteLine(MegaS);
        }
    }
}
