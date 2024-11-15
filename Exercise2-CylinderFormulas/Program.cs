using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_CylinderFormulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 2. Да се състави програма, която изчислява и извежда на екрана
            //околната повърхнина 's' и пълната повърхнина 'S' на цилиндър, като се
            //зададат височината 'H' и радиуса на основата 'R', по формулите:


            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Въведи височина на цилиндъра: ");
            double H = double.Parse(Console.ReadLine());
            Console.Write("Въведи радиуса на основата на цилиндъра: ");
            double R = double.Parse(Console.ReadLine());
            double s = 2 * Math.PI * R * H;
            double S = (2 * Math.PI * R * H) + (2 * Math.PI * Math.Pow(R, 2));

            Console.WriteLine("Околна повърхнина s = {0:F2}", s);
            Console.WriteLine("Пълната повърхнина S = {0:F2}", S);
        }
    }
}
