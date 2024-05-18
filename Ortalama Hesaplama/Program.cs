using System;

class Program
{
    // Özyinelemeli Fibonacci fonksiyonu
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        Console.Write("Derinliği giriniz: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Fibonacci dizisi 0'dan {n}'e kadar:");
        // Fibonacci dizisini oluştur ve elemanlarını topla
        int toplam = 0;
        for (int i = 0; i <= n-1; i++)
        {
            int fib = Fibonacci(i);
            toplam += fib;
            Console.WriteLine($"Fibonacci({i}) = {fib}");
        }
        // Dizinin ortalamasını hesapla
        double ortalama = (double)toplam / (n);
        // Ortalamayı yazdır
        Console.WriteLine($"Fibonacci dizisinin ilk {n} elemanının ortalaması: {ortalama}");
    }
}
