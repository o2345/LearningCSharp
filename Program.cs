using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашняя_работа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random rand = new Random();
            int max = int.MinValue;
            int max1 = int.MinValue;
            int min = int.MaxValue;
            int min1 = int.MaxValue;
            int max_pos = 0;
            int min_pos = 0;
            int sum = 0;
            int m = 1;
            int r = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 101);
                Console.WriteLine($"{array[i]} ");
                if (array[i] > max && array[i] > max1)
                {
                    max = array[i];
                    max_pos = i;
                }
                else if (array[i] < max && array[i] > max1)
                {
                    max1 = array[i];
                }
                if (array[i] < min && array[i] < min1)
                {
                    min = array[i];
                    min_pos = i;
                }
                else if (array[i] > min && array[i] < min1)
                {
                    min1 = array[i];
                }

                sum += array[i];
                m *= array[i];
                r = sum / array.Length;
            }

            Console.WriteLine("Максимальное число:" + max);
            Console.WriteLine("Минимальное число:" + min);
            Console.WriteLine("Позиция максимума:" + array[max_pos]);
            Console.WriteLine("Позиция минимума:" + array[min_pos]);
            Console.WriteLine("Сумма всех элементов:" + sum);
            Console.WriteLine("Произведение всех элементов:" + m);
            Console.WriteLine("Среднее арифметическое всех элементов:" + r);
            Console.WriteLine("Второе максимальное число:" + max1);
            Console.WriteLine("Второе минимальное число:" + min1);
        }
    }
}
