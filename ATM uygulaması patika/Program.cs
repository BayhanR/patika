using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ATMApp
{
    class Program
    {
        static Dictionary<string, int> registeredUsers = new Dictionary<string, int>
        {
            { "user1", 1000 },
            { "user2", 2000 },
            { "user3", 1500 }
        };

        static List<string> transactionLogs = new List<string>();
        static List<string> fraudLogs = new List<string>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("ATM Uygulamasına Hoşgeldiniz!");
                Console.Write("Kullanıcı Adınızı Girin: ");
                string username = Console.ReadLine();

                if (!registeredUsers.ContainsKey(username))
                {
                    Console.WriteLine("Kullanıcı bulunamadı. Lütfen tekrar deneyin.");
                    fraudLogs.Add($"Hatalı giriş denemesi - Kullanıcı: {username} - Zaman: {DateTime.Now}");
                    continue;
                }

                Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
                Console.WriteLine("1. Para Çekme");
                Console.WriteLine("2. Para Yatırma");
                Console.WriteLine("3. Ödeme Yapma");
                Console.WriteLine("4. Gün Sonu Al");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ParaCekme(username);
                        break;
                    case "2":
                        ParaYatirma(username);
                        break;
                    case "3":
                        OdemeYapma(username);
                        break;
                    case "4":
                        GunSonuAl();
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                        break;
                }
            }
        }

        static void ParaCekme(string username)
        {
            Console.Write("Çekmek istediğiniz tutarı girin: ");
            if (int.TryParse(Console.ReadLine(), out int amount))
            {
                if (registeredUsers[username] >= amount)
                {
                    registeredUsers[username] -= amount;
                    Console.WriteLine($"Başarıyla {amount} TL çektiniz. Güncel bakiyeniz: {registeredUsers[username]} TL");
                    transactionLogs.Add($"{username} {amount} TL çekti - Zaman: {DateTime.Now}");
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz tutar.");
            }
        }

        static void ParaYatirma(string username)
        {
            Console.Write("Yatırmak istediğiniz tutarı girin: ");
            if (int.TryParse(Console.ReadLine(), out int amount))
            {
                registeredUsers[username] += amount;
                Console.WriteLine($"Başarıyla {amount} TL yatırdınız. Güncel bakiyeniz: {registeredUsers[username]} TL");
                transactionLogs.Add($"{username} {amount} TL yatırdı - Zaman: {DateTime.Now}");
            }
            else
            {
                Console.WriteLine("Geçersiz tutar.");
            }
        }

        static void OdemeYapma(string username)
        {
            Console.Write("Ödemek istediğiniz tutarı girin: ");
            if (int.TryParse(Console.ReadLine(), out int amount))
            {
                if (registeredUsers[username] >= amount)
                {
                    registeredUsers[username] -= amount;
                    Console.WriteLine($"Başarıyla {amount} TL ödeme yaptınız. Güncel bakiyeniz: {registeredUsers[username]} TL");
                    transactionLogs.Add($"{username} {amount} TL ödeme yaptı - Zaman: {DateTime.Now}");
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz tutar.");
            }
        }

        static void GunSonuAl()
        {
            Console.WriteLine("Gün sonu alınıyor...");
            string date = DateTime.Now.ToString("ddMMyyyy");
            string filePath = $"EOD_{date}.txt";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Gün Sonu Raporu:");
                writer.WriteLine("İşlemler:");
                foreach (var log in transactionLogs)
                {
                    writer.WriteLine(log);
                }
                writer.WriteLine("\nFraud Logları:");
                foreach (var log in fraudLogs)
                {
                    writer.WriteLine(log);
                }
            }

            Console.WriteLine("Gün sonu raporu oluşturuldu. Dosya adı: " + filePath);
        }
    }
}

