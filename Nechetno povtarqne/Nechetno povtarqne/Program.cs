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

            string b = Console.ReadLine().ToLower();
            string[] a = b.Split(' ');
            var counts = new Dictionary<string, int>();
            foreach (var check in a)
                if (counts.ContainsKey(check))
                    counts[check]++;
                else counts[check] = 1;
            var results = new List<string>();

            foreach (var pair in counts)
            {
                if (pair.Value % 2 == 1) results.Add(pair.Key);

            }
                Console.WriteLine(string.Join(", ", results));


        }
    }
}
