using System;
using System.Collections.Generic;
using System.Linq;

namespace VotingApp
{
    class Program
    {
        static List<string> predefinedCategories = new List<string>
        {
            "Film Kategorileri",
            "Tech Stack Kategorileri",
            "Spor Kategorileri"
        };

        static Dictionary<string, int[]> categoryVotes = new Dictionary<string, int[]>();

        static List<string> registeredUsers = new List<string>();

        static void Main(string[] args)
        {
            foreach (var category in predefinedCategories)
            {
                categoryVotes[category] = new int[predefinedCategories.Count];
            }

            Console.WriteLine("Oylama Uygulamasına Hoşgeldiniz!");

            while (true)
            {
                Console.Write("Kullanıcı Adınızı Girin (Çıkmak için 'exit' yazın): ");
                string username = Console.ReadLine();

                if (username.ToLower() == "exit")
                {
                    ShowResults();
                    break;
                }

                if (!registeredUsers.Contains(username))
                {
                    Console.WriteLine("Kayıtlı kullanıcı bulunamadı. Kayıt olmak ister misiniz? (E/H): ");
                    string registerResponse = Console.ReadLine();

                    if (registerResponse.ToLower() == "e")
                    {
                        registeredUsers.Add(username);
                        Console.WriteLine("Kayıt başarılı!");
                    }
                    else
                    {
                        continue;
                    }
                }

                Vote(username);
            }
        }

        static void Vote(string username)
        {
            Console.WriteLine("Oylama Kategorileri:");
            for (int i = 0; i < predefinedCategories.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {predefinedCategories[i]}");
            }

            Console.Write("Oy vermek istediğiniz kategorinin numarasını girin: ");
            if (int.TryParse(Console.ReadLine(), out int categoryIndex) && categoryIndex >= 1 && categoryIndex <= predefinedCategories.Count)
            {
                categoryIndex--; // Kullanıcı girişi 1'den başladığı için indeksi düzelt
                categoryVotes[predefinedCategories[categoryIndex]][categoryIndex]++;
                Console.WriteLine("Oyunuz başarıyla kaydedildi!");
            }
            else
            {
                Console.WriteLine("Geçersiz kategori numarası.");
            }
        }

        static void ShowResults()
        {
            Console.WriteLine("\nOylama Sonuçları:");
            foreach (var category in predefinedCategories)
            {
                int totalVotes = categoryVotes[category].Sum();
                Console.WriteLine($"{category}: {totalVotes} oy");

                if (totalVotes > 0)
                {
                    for (int i = 0; i < predefinedCategories.Count; i++)
                    {
                        double percentage = (double)categoryVotes[category][i] / totalVotes * 100;
                        Console.WriteLine($"  {predefinedCategories[i]}: {categoryVotes[category][i]} oy (%{percentage:F2})");
                    }
                }
            }
        }
    }
}
