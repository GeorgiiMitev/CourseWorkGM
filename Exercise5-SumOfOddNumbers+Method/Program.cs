using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5_SumOfOddNumbers_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задача 5. Да се въведат от клавиатурата произволни числа и произволен брой ненулвеи числа
            // (за край на въвеждането служи числото 0). Да се отпечата сумата на тези от тях които са нечетни.

            Console.OutputEncoding = Encoding.UTF8;
            int sum = 0;
            int lastNum = 0;
            int num;
            do
            {
                Console.Write("Enter a number: ");
                num = int.Parse(Console.ReadLine());
                if (num % 2 == 1)
                {
                    lastNum = lastNum + num;
                    lastNum = num;
                    sum += lastNum;

                }
            } while (num > 0);
            Console.WriteLine($"End of program. The total sum for the odd numbers was {sum}");
            Console.WriteLine("------------------------");
            Console.WriteLine();


            ///////////////////
            ///     2. Да се въведат от клавиатурата 8 положителни числа. Да се намери и отпечата на екрана
            ///     средно геометричното (корен осми от произведението) на тези числа.
            ///////////////////
            double product = 1.0;
            for (int i = 1; i <= 8; i++)
            {
                Console.Write($"Enter number {i}: ");
                int n = int.Parse(Console.ReadLine());
                product = product * n;

            }
            // Пресмятане на средното геометрично( корен осми от произведението 'product' )
            double squared = Math.Pow(product, 1.0 / 8.0);
            Console.WriteLine("Squared answer: {0:F2}", squared);
            Console.WriteLine();
            Console.WriteLine();

            // 3. Да се създаде метод SSS(k) който генерира k на брой случайни цели числа
            // и като резултат връща произведението на тези от тях които са двуцифрени
            // и завършват на 5.
            Console.Write("Въведи k (служи за генериране на k на брой случайни числа в зададения диапазон): ");
            int k = int.Parse(Console.ReadLine());
            
            // В главния метод да се въведат 3 цели положителни числа 
            Console.Write("Въведи a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Въведи b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Въведи c: ");
            int c = int.Parse(Console.ReadLine());            
            Sss(k, a, b, c);

            Console.WriteLine($"Резултатът от (a - b) * (b + c): {(a - b) * (b + c)}");
        }
        static void Sss(int k, int a, int b, int c)
        {
            Random random = new Random();
            int count = 0;
            for (int i = 0; i < k; i++)
            {
                int randomNumber = random.Next(10, 101);
                if (randomNumber>= 10 && randomNumber <= 99 && randomNumber % 10 == 5)
                {
                    count++;
                    Console.WriteLine($"Числото което е двуцифрено и завършва на 5: {randomNumber}");
                }
            }
            Console.WriteLine($"Брой на числата които са двуцифрени и завършват на 5: {count}");

            Console.WriteLine();
            Console.WriteLine($"Резултатът от (a - b) * (b + c): {(a - b) * (b + c)}");
            Console.WriteLine();
        }

        // oh, you found an easter egg! 🥚
    }
}
