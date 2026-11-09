using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите оператор: ");
            string oper = Console.ReadLine();
            switch (oper)
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;
                case "-":
                    Console.WriteLine(a - b);
                    break;
                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "/":
                    if (b == 0) Console.WriteLine("Деление на ноль не поддерживается");
                    Console.WriteLine(a / b);
                    break;
                default:
                    Console.WriteLine("Неизвестная операция");
                    break;
            }
        }
    }
}
