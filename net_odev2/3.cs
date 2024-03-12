using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

            Console.WriteLine("Cümle Giriniz");
            string sentence = Console.ReadLine();
            string vowel = @"[aeıuüioö]";
            Regex rg = new Regex(vowel);
            MatchCollection vowelSounds = rg.Matches(sentence);

            foreach (var item in vowelSounds)
            {
                Console.Write(item+",");
            }
            
            
        }
    }
}