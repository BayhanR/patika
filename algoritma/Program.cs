using System;

namespace StringIndexSilme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String ve indeks bilgilerini girin (örnek: Algoritma,3):");
            string input = Console.ReadLine();
            string[] inputs = input.Split(',');

            if (inputs.Length != 2)
            {
                Console.WriteLine("Geçersiz giriş. Lütfen doğru formatta (örnek: Algoritma,3) giriş yapın.");
                return;
            }
            string metin = inputs[0];
            int indeks;
            if (!int.TryParse(inputs[1], out indeks))
            {
                Console.WriteLine("Geçersiz indeks değeri. Lütfen bir sayı girin.");
                return;
            }
            if (indeks < 0 || indeks >= metin.Length)
            {
                Console.WriteLine("Geçersiz indeks değeri. İndeks, string ifadenin geçerli aralığında olmalıdır.");
                return;
            }
            string sonuc = KarakterSil(metin, indeks);
            Console.WriteLine($"Sonuç: {sonuc}");
        }
        static string KarakterSil(string metin, int indeks)
        {
            return metin.Substring(0, indeks) + metin.Substring(indeks + 1);
        }
    }
}
