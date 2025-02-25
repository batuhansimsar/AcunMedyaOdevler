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

        // 10'dan küçük olan elemanları sil
        for (int i = liste.Count - 1; i >= 0; i--) // Geriye doğru iterasyon
        {
            if (liste[i] < 10)
            {
                liste.RemoveAt(i); // RemoveAt() metodu, belirli bir indeksteki elemanı siler.
            }
        }

        // Kalan elemanları yazdır
        Console.WriteLine("\nKalan Liste:");
        foreach (int num in liste)
        {
            Console.WriteLine(num);
        }
    }
}



