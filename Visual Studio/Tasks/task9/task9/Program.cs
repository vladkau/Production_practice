using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1,100);
            }
            int min = array[0];
            int max = array[0];
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
                sum += array[i];
            }
            double avg = sum / array.Length;
            Console.WriteLine(string.Join(", ", array));
            Console.WriteLine("Минимум: " + min);
            Console.WriteLine("Максимум: " + max);
            Console.WriteLine("Сумма: " + sum);
            Console.WriteLine("Среднее: " + avg);
        }
    }
}
