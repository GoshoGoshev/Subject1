using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    { static int SUMdr(int a)
        {
            int s2 = 0;
            while (a != 0)
            {
                if (a % 10 % 2 != 0) s2 = s2 + a % 10;
                a = a / 10;
            }
            return s2;
        }
            static int SUMeven(int a)
            {
                int s1=0;
                while(a!=0)
                {
                    if(a%10%2==0)s1=s1+a%10;
                    a = a / 10;
                }
                return s1;}


        static void Main(string[] args)
        { 
            var a=int.Parse(Console.ReadLine());
            int q=SUMeven(a)*SUMdr(a);
        Console.WriteLine(q);
        }

       
            }
    }

