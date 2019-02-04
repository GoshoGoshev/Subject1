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
            if (a == "int") { Console.WriteLine(int.MaxValue); Console.WriteLine(int.MinValue); }
            if (a == "uint") { Console.WriteLine(uint.MaxValue); Console.WriteLine(uint.MinValue); }
            if (a == "long") { Console.WriteLine(long.MaxValue); Console.WriteLine(long.MinValue); }
            if (a == "byte") { Console.WriteLine(byte.MaxValue); Console.WriteLine(byte.MinValue); }
            if (a == "sbyte") { Console.WriteLine(sbyte.MaxValue); Console.WriteLine(sbyte.MinValue); }
        }
    }
}
