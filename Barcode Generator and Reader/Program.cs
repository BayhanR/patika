using System;
using IronBarCode;

namespace BarcodeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Barkod Oluştur");
            Console.WriteLine("2. Barkod Oku");
            Console.Write("Seçiminizi yapın: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Barkod verisini girin: ");
                string data = Console.ReadLine();

                // Barkod oluşturma işlemi
                string filePath = "barcode.png"; // Örnek dosya yolu
                GenerateBarcode(data, filePath);
            }
            else if (choice == "2")
            {
                Console.Write("Okunacak barkod dosya yolunu girin (örnek: C:\\barcodes\\barcode.png): ");
                string filePath = Console.ReadLine();

                // Barkod okuma işlemi
                Reader(filePath);
            }
            else
            {
                Console.WriteLine("Geçersiz seçim.");
            }
        }

        static void GenerateBarcode(string data, string filePath)
        {
            if (string.IsNullOrEmpty(data) || string.IsNullOrEmpty(filePath))
            {
                Console.WriteLine("Geçersiz giriş.");
                return;
            }

            // Barkod oluşturma işlemi
            var barcodeWriter = BarcodeWriter.CreateBarcode(data, BarcodeWriterEncoding.Code128);
            barcodeWriter.SaveAsPng(filePath);

            Console.WriteLine($"Barkod başarıyla oluşturuldu ve {filePath} konumuna kaydedildi.");
        }

        static void Reader(string filePath)
        {
            try
            {
                Console.WriteLine("Barkod okunuyor ...");

                BarcodeResult[] results = BarcodeReader.Read(filePath).ToArray();
                Console.WriteLine(results[0].Text);
                Console.WriteLine("Barkod okundu!");
            }
            catch (Exception)
            {
                Console.WriteLine("Barkod bulunamadı!");
            }
        }
    }
}
