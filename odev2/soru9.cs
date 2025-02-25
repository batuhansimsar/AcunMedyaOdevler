using System;
using System.Collections.Generic; // List kullanmak için gerekli

class Program
{
    static void Main()
    {
        // Kullanıcıdan bir sayı al
        Console.Write("Bir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        
        // Listeyi oluştur
        List<int> liste = new List<int>();

        // Listeye eleman ekle
        for (int i = 0; i < sayi; i++)
        {
            Console.Write($"Listeye {i + 1}. elemanı giriniz: ");
            liste.Add(Convert.ToInt32(Console.ReadLine()));
        }

        // Listeyi küçükten büyüğe sırala
        liste.Sort();

        // Ortalamayı hesapla
        int toplam = 0;
        foreach (int eleman in liste)
        {
            toplam += eleman;
        }
        
        // Ortalama yazdır
        Console.WriteLine($"Ortalama: {toplam / sayi}");
        
        // Sıralı listeyi yazdır
        Console.WriteLine("\nSıralı Liste:");
        foreach (int eleman in liste)
        {
            Console.WriteLine(eleman);
        }
    }
}


