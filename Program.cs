using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Вариант 1
Дана строка. Словом текста считается любая последовательность букв латинского
алфавита; между соседними словами - не менее одного пробела, за последним словом -
точка. Найти и сохранить в строке те слова последовательности, которые отличны от
первого слова, предварительно преобразовав каждое из них по следующему правилу:
перенести первую букву в конец слова. Все остальные слова удалить.*/

namespace _3_2_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "home  house  home window door .";
            char[] sep = { ' ', '.' };
            string[] myWord = myString.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            string newString = "";
            for (int i = 0; i < myWord.Length; i++)
            {
                if (myWord[i] != myWord[0])
                {
                    myWord[i] = myWord[i].Substring(1) + myWord[i][0];
                    newString += myWord[i] + " ";
                }                
            }
            Console.WriteLine("{0}", newString);

            Console.ReadKey();
        }
    }
}
