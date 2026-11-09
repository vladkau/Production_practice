using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string a = Console.ReadLine();

            string reverse(string s)
            {
                if (s == "")
                {
                    return "";
                }
                string new_str = "";
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    new_str += s[i];
                }
                return new_str;
            }
            Console.WriteLine(reverse(a));
        }
    }
}
