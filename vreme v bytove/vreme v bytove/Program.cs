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
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine(sbyte.MaxValue);
            double b=(int)a*10000;
            if (b != a * 10000) Console.WriteLine("Rainy");
            if (b > 0&&b<=sbyte.MaxValue) Console.WriteLine("Sunny");
            if (b > sbyte.MaxValue&&b<=int.MaxValue) Console.WriteLine("Cloudy");
            if (b >int.MaxValue&&b<=long.MaxValue) Console.WriteLine("Windy");
        }
    }
}
