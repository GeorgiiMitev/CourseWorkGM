using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Convertion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Задача 1. Конвертиране на числото 2062 в 2-ична, 8-чна и 16-ична бройна система

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"2062 converted to BINARY is: {Convert.ToString(2062, 2)} \n");
            Console.WriteLine($"2062 converted to OCTAL is: {Convert.ToString(2062, 8)} \n");
            Console.WriteLine($"2062 converted to HEXADECIMAL is: {Convert.ToString(2062, 16)}");

            
        }
    }
}
