using System;

namespace UcgenCiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üçgenin boyutunu belirtin:");
            int boyut = Convert.ToInt32(Console.ReadLine());

            Ucgen ucgen = new Ucgen();
            ucgen.Ciz(boyut);
        }
    }

    public class Ucgen
    {
        public void Ciz(int boyut)
        {
            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}

