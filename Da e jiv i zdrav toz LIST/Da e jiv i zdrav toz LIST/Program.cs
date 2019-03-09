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
            var d=new Dictionary<string,string>();
            var result=new List<string>();
           // string b;
            for (int i = 0; i < 3; i++)
            {
                var b = Console.ReadLine();
                string[] a = b.Split(' ');
                int k = a.Length;
                //Console.WriteLine(c[0]);
                if (a[0] == "A") d.Add(a[1], a[k - 1]);
                if (a[0] == "S") foreach (var check in d) if (check.Key == a[1])  result.Add(check.Key+"->"+check.Value); 
                        else result.Add("Invalid number");
            }
            foreach (var p in result)
            {
                //if (p == "Invalid number") { Console.WriteLine(); 
                Console.WriteLine(p);
                //else Console.Write(p + "->");
            } Console.WriteLine();
        }
    }
}
