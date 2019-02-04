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
            var b = Convert.ToBoolean(a);
            if (b == true) Console.WriteLine("Yes");
            else Console.WriteLine("No");

        }
    }
}
