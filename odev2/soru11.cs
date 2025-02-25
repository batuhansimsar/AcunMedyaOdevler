using System;
using System.Collections.Generic; // List kullanmak için gerekli

class Program
{
    static void Main()
    {
        // Listeyi doğru bir şekilde başlat
        List<int> liste = new List<int> { 34, 53, 21, 32, 15, 45, 67, 89, 90, 101, 112, 123, 134, 145 };

        // Liste elemanlarını kontrol et
        for (int i = 0; i < liste.Count; i++)
        {
            if (liste[i] < 50)
            {
                liste[i] = 50; // 50'den küçük olanları 50 yap
            }
        }

        // Sonuçları yazdır
        Console.WriteLine("Güncellenmiş Liste:");
        foreach (int num in liste)
        {
            Console.WriteLine(num);
        }
    }
}
