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
            double b, S = 0; int br = a.Length-1;
                for(int j=0;j<='\0';j++)
                {
                    if (a[j] == '1') { b = 1; S = S + b * Math.Pow(16, br); }
                    if (a[j] == '2') { b = 2; S = S + b * Math.Pow(16, br); }
                    if (a[j] == '3') { b = 3; S = S + b * Math.Pow(16, br); }
                    if (a[j] == '4') { b = 4; S = S + b * Math.Pow(16,br); }
                    if (a[j] == '5') { b = 5; S = S + b * Math.Pow(16,br); }
                    if (a[j] == '6') { b = 6; S = S + b * Math.Pow(16, br); }
                    if (a[j] == '7') { b = 7; S = S + b * Math.Pow(16, br); }
                    if (a[j] == '8') { b = 8; S = S + b * Math.Pow(16, br); }
                    if (a[j] == '9') { b = 9; S = S + b * Math.Pow(16, br); }
                    if (a[j] == 'A') { b = 10; S = S + b * Math.Pow(16,br); }
                    if (a[j] == 'B') { b = 11; S = S + b * Math.Pow(16,br); }
                    if (a[j] == 'C') { b = 12; S = S + b * Math.Pow(16, br); }
                    if (a[j] == 'D') { b = 13; S = S + b * Math.Pow(16, br); }
                    if (a[j] == 'E') { b = 14; S = S + b * Math.Pow(16, br); }
                    if (a[j] == 'F') { b = 15; S = S + b * Math.Pow(16,br); }
                    br--;
            }
                Console.WriteLine(S);
        }
    }
}
