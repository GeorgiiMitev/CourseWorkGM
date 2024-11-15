using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_ProgramFragment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 3. Запишете като фрагмент от програма следната функция:
            //          y=x+2 за x<=0 | y=x-2 за 0<x<1 | y=3x за x>1

            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Въведи x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Въведи y: ");
            double y = double.Parse(Console.ReadLine());

            if(x <= 0)
            {
                y = x + 2;
                Console.WriteLine($"Y = {y}");
            }
            else if(x > 0 && x < 1)
            {
                y = x - 2;
                Console.WriteLine($"Y = {y}");
            }
            else if(x >= 1)
            {
                y = x * 3;
                Console.WriteLine($"Y = {y}");
            }
            else
            {
                Console.WriteLine("Error. Please try again.");
            }

        }
    }
}
