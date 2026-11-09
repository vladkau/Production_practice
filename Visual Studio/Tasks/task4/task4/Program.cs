using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            double a = double.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Число чётное");
            }
            else
            {
                Console.WriteLine("Число нечётное");
            }
            string res = a % 2 == 0 ? "Чётное" : "Нечётное"; 
            Console.WriteLine(res);
        }
    }
}
