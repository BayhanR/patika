using System;

namespace Mutlak_Kare_Alma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ikişer integer giriniz");
            string input = Console.ReadLine();
            string[] inputArr = input.Split(' ');
            int mutlakToplam=0, mutlakToplamKaresi=0;
            
            for (int i = 0; i < inputArr.Length; i++)
            {
                if (int.Parse(inputArr[i])<67)
                {
                    mutlakToplam +=(67-int.Parse(inputArr[i]));
                }
                else
                {
                    mutlakToplamKaresi += (int)(Math.Pow((int.Parse(inputArr[i]) - 67),2));
                }
            }
            Console.WriteLine($"67'den küçük olanların farklarının toplamı: {mutlakToplam}");
            Console.WriteLine($"67'den büyük olanların farklarının mutlak karelerinin toplamı: {mutlakToplamKaresi}");
        
    }
    }
}
