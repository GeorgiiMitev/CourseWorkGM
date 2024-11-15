using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7_SearchingIfAStringIsContained
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a keyword that would be searched: ");
            string keyword = Console.ReadLine();
            Console.Write("Enter a word that should be before the main keyword");
            string wordBefore = Console.ReadLine();
            Console.Write("Enter a word that should be after the main keyword");
            string wordAfter = Console.ReadLine();
            Console.Write("Enter random text containing any of the above strings concatenated together (or not): ");
            string text = Console.ReadLine();

            //Връща ни цяло число на точната позиция на keyworda 
            int firstMetIndexPosKeyword = text.IndexOf(keyword);

            //Разгледах че Index/LastIndexOf връщат -1 ако не е намерен низ който сме задали в текста който обхождаме,
            //така че въртим докато съществува
            while (firstMetIndexPosKeyword != -1)
            {
                // Проверка дали низът който търсим е преди keyword-а, ако да - връща true
                bool before = text.LastIndexOf(wordBefore, firstMetIndexPosKeyword) != -1;

                // Проверка дали низът който търсим след keyword-а се намира на позиция след него, ако да - връща true
                bool after = text.IndexOf(wordAfter, firstMetIndexPosKeyword + keyword.Length) != -1;

                //Ако низовете които търсим се намират преди и след keyword-a (true true) извежда на конзолата:
                if (before == true && after == true)
                {
                    Console.WriteLine($"Намерен е Keyword-a на позиция {firstMetIndexPosKeyword} със прилепен низ {wordBefore} преди и низът {wordAfter} след");
                }

                //Повторно търсене веднага след намиране на дадения keyword
                //e.g ако е намерено на позиция 0, ще завърти отново и ще тръгне да търси от позиция 1 нататък докато не остане нишо за търсене
                firstMetIndexPosKeyword = text.IndexOf(keyword, firstMetIndexPosKeyword + 1);
            }

        }
    }
}
