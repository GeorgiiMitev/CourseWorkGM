using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6_1DArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задача 7. 
            // 1. Да се направят два метода:
            // а) за въвеждане на едномерен целочислен масив

            // б) за изчисляване на сумата на тези елементи на целочисления масив,
            // които са нечетни и принадлежат на интервала (0, 100)

            Console.OutputEncoding = Encoding.UTF8;
            int[] array = Initialise1DArray();
            CalculateArray(array);
        }
        static int[] Initialise1DArray()
        {
            Console.Write("Въведи числа разделени с разстояние: ");
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            return array;
            
        }
        static void CalculateArray(int[] array)
        {
            int sum = 0;
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1 && array[i] >= 0 && array[i] <= 100)
                {
                    sum = sum + array[i];
                    result = sum;
                }
            }
            Console.WriteLine($"Сумата на всички нечетни числа в интервала (0, 100): {result} \n");
        }
    }
}
