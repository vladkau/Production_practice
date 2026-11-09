using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            long b = 101;
            double c = 4.5;
            float d = 1.0f;
            decimal e = 12.8m;
            bool f = true;
            char g = 'a';
            string h = "привет";
            Console.WriteLine($"a = {a}({a.GetType()})\n" +
                $"b = {b}({b.GetType()})\n" +
                $"c = {c}({c.GetType()})\n" +
                $"d = {d}({d.GetType()})\n" +
                $"e = {e}({e.GetType()})\n" +
                $"f = {f}({f.GetType()})\n" +
                $"g = {g}({g.GetType()})\n" +
                $"h = {h}({h.GetType()})");
        }
    }
}
