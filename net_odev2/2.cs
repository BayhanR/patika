using System;
using System.Collections;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

            Console.WriteLine("20 Adet Sayı Giriniz");
            ArrayList alignment = new ArrayList();
            ArrayList bigNum = new ArrayList();
            ArrayList littleNum = new ArrayList();
            

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine((i+1) + ". Sayıyı Giriniz");
                int number =Convert.ToInt32(Console.ReadLine());
                
                bigNum.Add(number);
                littleNum.Add(number);
                alignment.Add(number);

            }
            Console.WriteLine("BÜYÜKTEN KÜÇÜĞE İLK 3 SAYI");

            bigNum.Sort();
            bigNum.Reverse();
            
            for (int i = 0; i < 3; i++)
            {   
                Console.Write(bigNum[i]);
            }
            bigNum.RemoveRange(3,17);

            //ArrayList Dizi'ye Çevirilip Dizi Metodu Kullanıldı
            int[] arrBigNum = new int[3];
            arrBigNum =(int[]) bigNum.ToArray(typeof(int));
            
            int bigNumTotal =Sum(arrBigNum);
            double bigNumAverage = Average(arrBigNum);

            Console.WriteLine("\n Toplam = "+ bigNumTotal);
            Console.WriteLine("Ortalama = " + bigNumAverage );
            
            Console.WriteLine("**************************");

            
            Console.WriteLine("\n KÜÇÜKTEN BÜYÜĞE İLK 3 SAYI");
            
            littleNum.Sort();
            for (int i = 0; i < 3; i++)
            {
                Console.Write(littleNum[i]);
            }
            littleNum.RemoveRange(3,17);

            //ArrayList Dizi'ye Çevirilip Dizi Metodu Kullanıldı
            int[] arrLittleNum = new int[3];
            arrLittleNum =(int[]) littleNum.ToArray(typeof(int));
            
            int littleNumTotal = Sum(arrLittleNum);
            double littleNumAverage = Average(arrLittleNum);

            Console.WriteLine("\n Toplam = "+ littleNumTotal);
            Console.WriteLine("Ortalama = " + littleNumAverage);

            Console.WriteLine("ORTALAMALARIN TOPLAMI");

            double totalAverage = littleNumAverage + bigNumAverage;
            Console.WriteLine(totalAverage);
        }
        //Toplam Metodu
        static int Sum(int[] num)
        {
            int total =  0;
           
            for (int i = 0; i < num.Length; i++)
            {
                total += num[i] ;
            }
            return total;
        }
        //Ortalama Metodu
        static double Average(int[] num)
        {
            double average = 0;
            int total = 0;

            for (int i = 0; i < num.Length; ++i)
            {
                total += num[i]; 
            }
            average = (double)total / (num.Length);

            return average;
        }
    }
}