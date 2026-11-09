using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            string s = i.ToString();
            for (i = 1; i <= 100; i++)
            {
                if (i % 15 == 0) s = "FizzBuzz";
                else if (i % 3 == 0) s = "Fizz";
                else if (i % 5 == 0) s = "Buzz";
                else s = i.ToString();
                Console.WriteLine(s);
            }
        }
    }
}
