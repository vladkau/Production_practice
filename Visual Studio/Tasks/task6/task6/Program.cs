using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            int nums_sum_string(int num)
            {
                num = Math.Abs(num);
                string s = num.ToString();
                int sum = 0;
                foreach (char c in s) sum += int.Parse(c.ToString());
                return sum;
            }
            Console.WriteLine(nums_sum_string(a));
            int nums_sum(int num)
            {
                num = Math.Abs(num);
                int sum = 0;
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                return sum;         
            }
            Console.WriteLine(nums_sum(a));
        }
    }
}
