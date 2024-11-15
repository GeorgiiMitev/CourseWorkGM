using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_RandomNumbersInterval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задача. 4 (209e) Да се генерира редица от 100 случайни цели числа принадлежащи на интервала [0, 132].
            // Да се отпечатат тези от тях които:
            // е) принадлежат на интервала [26, 100]


            Console.OutputEncoding = Encoding.UTF8;
            int count = 0;
            Random randomNumber = new Random();
            for (int i = 0; i < 100; i++)
            {
                int num = randomNumber.Next(0, 133);
                if (num >= 26 && num <= 100)
                {
                    count++;
                    Console.Write($"{num}"+ " ");
                    
                }
                
            }
            Console.WriteLine($"\n\nCount of numbers that are in the interval [26, 100]: {count}");
        }
    }
}
