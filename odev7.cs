using System;

class Program
{
    static void Main()
    {
        // 1. Soru: Dizi (Array) nedir? Ne işe yarar? Gerçek hayattan bir örnek verin.
        /*
            - Dizi (Array): Aynı türdeki verileri bir arada tutan bir veri yapısıdır.
            - Ne İşe Yarar?: Birden fazla değeri tek bir değişken altında saklamak ve bu değerlere indeks numaralarıyla erişmek için kullanılır.
            - Gerçek Hayat Örneği: Bir sınıftaki öğrencilerin notlarını saklamak için dizi kullanılabilir.
              Örneğin, 30 öğrencinin notları bir dizi içinde tutulabilir ve her bir not, dizinin bir elemanı olarak saklanır.
        */

        // 2. Soru: 5 elemanlı bir int dizisi oluşturup, kullanıcıdan aldığı değerlerle diziyi dolduran ve ekrana yazdıran bir program yazın.
        int[] dizi = new int[5]; // 5 elemanlı bir dizi oluştur

        Console.WriteLine("5 tane sayı girin:");

        // Kullanıcıdan değerleri al ve diziye ata
        for (int i = 0; i < dizi.Length; i++)
        {
            Console.Write((i + 1) + ". sayıyı girin: ");
            dizi[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Diziyi ekrana yazdır
        Console.WriteLine("\nGirdiğiniz sayılar:");
        for (int i = 0; i < dizi.Length; i++)
        {
            Console.Write(dizi[i] + " ");
        }
        Console.WriteLine(); // Yeni satıra geç

        // 3. Soru: Bir dizinin içindeki en büyük sayıyı bulan bir C# programı yazın.
        int enBuyuk = dizi[0]; // İlk elemanı en büyük olarak varsay

        // Diziyi tarayarak en büyük sayıyı bul
        for (int i = 1; i < dizi.Length; i++)
        {
            if (dizi[i] > enBuyuk)
            {
                enBuyuk = dizi[i];
            }
        }

        Console.WriteLine("\nDizideki en büyük sayı: " + enBuyuk);
    }
}
