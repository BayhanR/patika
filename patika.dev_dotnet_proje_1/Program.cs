using System;
using System.Collections.Generic;
using System.Linq;
namespace patika.dev_dotnet_proje1
{
    internal class Program
    {
        static Dictionary<string, string> rehber = new Dictionary<string, string>()
        {
            {"Ali","123456778"},
            {"Ayşe","463465235"},
            {"Fatma","241512515"},
            {"Ahmet","22352353125"},
            {"Mehmet","241241241255"}
        };
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("\nTelefon Rehberi Uygulaması\n");
                Console.WriteLine("1. Telefon Numarası Kaydet");
                Console.WriteLine("2. Telefon Numarası Sil");
                Console.WriteLine("3. Telefon Numarası Güncelle");
                Console.WriteLine("4. Rehber Listeleme (A-Z)");
                Console.WriteLine("5. Rehber Listeleme (Z-A)");
                Console.WriteLine("6. Rehberde Arama");
                Console.WriteLine("7. Çıkış");
                Console.Write("\nLütfen yapmak istediğiniz işlemi seçin: ");

                int secim;
                if (!int.TryParse(Console.ReadLine(), out secim) || secim < 1 || secim > 7)
                {
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                    continue;
                }

                switch (secim)
                {
                    case 1:
                        TelefonNumarasiKaydet();
                        break;
                    case 2:
                        TelefonNumarasiSil();
                        break;
                    case 3:
                        TelefonNumarasiGuncelle();
                        break;
                    case 4:
                        RehberListele();
                        break;
                    case 5:
                        RehberListeleTers();
                        break;
                    case 6:
                        RehberdeAra();
                        break;
                    case 7:
                        Console.WriteLine("Çıkış yapılıyor...");
                        return;
                }

            }
            static void TelefonNumarasiKaydet()
            {
                Console.WriteLine("Kisinin adin giriniz");
                string ad = Console.ReadLine();
                Console.WriteLine("Kisinin telefon numarasini giriniz");
                string telefon = Console.ReadLine();

                rehber.Add(ad, telefon);
                Console.WriteLine($"{ad} adlı kişinin numarası kaydedildi.");
            }
            static void TelefonNumarasiSil()
            {
                Console.WriteLine("Slmek istediginiz ksnin adini giriniz");
                string ad=Console.ReadLine();
                if (rehber.Remove(ad))
                {
                    Console.WriteLine($"{ad} adli kisinin numarasi basariya silindi.");
                }
                else
                {
                    Console.WriteLine("Belirtilen isimde kisi bulunamadi");
                }
            }
            static void TelefonNumarasiGuncelle()
            {
                Console.Write("Güncellemek istediğiniz kişinin adını girin: ");
                string ad = Console.ReadLine();
                if (rehber.ContainsKey(ad))
                {
                    string telefon = Console.ReadLine();
                    rehber[ad] = telefon;
                }
                else
                {
                    Console.WriteLine("Guncellemek istediginiz kisi bulunamadi");
                }
            }
            static void RehberListele()
            {
                Console.WriteLine("Rehber Listesi (Z-A):");
                foreach (var entry in rehber.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"{entry.Key}: {entry.Value}");
                }
            }
            static void RehberListeleTers()
            {
                Console.WriteLine("Rehber Listesi (Z-A):");
                foreach (var entry in rehber.OrderByDescending(x => x.Key))
                {
                    Console.WriteLine($"{entry.Key}: {entry.Value}");
                }
            }

            static void RehberdeAra()
            {
                Console.WriteLine("Aramak istediginiz kisinin adni giriniz");
                string ad = Console.ReadLine();
                if (rehber.ContainsKey(ad))
                {
                    Console.WriteLine($"{ad}:{rehber[ad]}");
                }
                else
                {
                    Console.WriteLine("Aradiginiz kisi bulunamadi");
                }
            }
        }

    }
}
