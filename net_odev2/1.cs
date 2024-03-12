using System;
using System.Collections;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru - 1: Klavyeden girilen 20 adet pozitif say�n�n asal ve asal olmayan olarak 2 ayr� listeye at�n. (ArrayList s�n�f�n� kullanara yaz�n�z.)

            /*
              -Negatif ve numeric olmayan giri�leri engelleyin.
              -Her bir dizinin elemanlar�n� b�y�kten k����e olacak �ekilde ekrana yazd�r�n.
              -Her iki dizinin eleman say�s�n� ve ortalamas�n� ekrana yazd�r�n.
            */


            ArrayList prime = new ArrayList();
            ArrayList notPrime = new ArrayList();

            Console.WriteLine("20 Adet Pozitif Say� Giriniz");


            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine((i + 1) + ". Say�");
                string num = Console.ReadLine();
                if (IsItLetter(num))
                {

                    int number = int.Parse(num);
                    int[] numbers = new int[number];

                    if (ItIsPrime(number) == false)
                    {
                        notPrime.Add(number);
                    }
                    else
                    {
                        prime.Add(number);
                    }

                }

            }

            Console.WriteLine("******Asal Say�lar******");
            prime.Sort();
            prime.Reverse();
            foreach (var item in prime)
            {
                Console.Write(item + ",");

            }
            Console.WriteLine("Eleman Say�s�: " + prime.Count);

            //ArrayList diziye �evrilip dizi metotu kullan�ld�
            int[] arrPrime = new int[20];
            arrPrime = (int[])prime.ToArray(typeof(int));

            Console.WriteLine("Toplam: " + Sum(arrPrime));
            Console.WriteLine("Ortalama: " + Average(arrPrime));


            Console.WriteLine("******Asal Olmayan Say�lar******");
            notPrime.Sort();
            notPrime.Reverse();
            foreach (var item in notPrime)
            {
                Console.Write(item + ",");
            }

            Console.WriteLine("Eleman Say�s�: " + notPrime.Count);

            //ArrayList diziye �evrilip dizi metotu kullan�ld�
            int[] arrNotPrime = new int[20];
            arrNotPrime = (int[])notPrime.ToArray(typeof(int));

            Console.WriteLine("Toplam: " + Sum(arrNotPrime));
            Console.WriteLine("Ortalama: " + Average(arrNotPrime));

        }
        // Asal m� De�il mi kontrol�n� yapan metod
        static bool ItIsPrime(int a)
        {

            if (a < 2 || (a % 2 == 0 && a != 2))
            {
                return false;
            }

            else
            {
                for (int i = 3; i < a; i += 2)
                {
                    if (a % i == 0)
                    {
                        return false;

                    }
                }
            }
            return true;
        }
        //Toplama Metodu
        static int Sum(int[] num)
        {
            int total = 0;

            for (int i = 0; i < num.Length; i++)
            {
                total += num[i];
            }
            return total;
        }
        //Ortalama Alma Metodu
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
        static bool IsItLetter(string thisNumber)
        {
            bool result = int.TryParse(thisNumber, out int outNumber);

            if (result)
            {
                if (outNumber > 0)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("L�tfen Pozitif Bir Say� Giriniz");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Harf Girdiniz!");
                return false;
            }
        }




    }

}