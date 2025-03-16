using System;

class Program
{
    static void Main()
    {
        // 1. Soru: Döngüler (for, while) ne işe yarar? Hangisi hangi durumda kullanılır?
        /*
            - For döngüsü: Belirli bir başlangıç değeri, bitiş koşulu ve artış miktarı ile çalışır.
              Genellikle kaç kez tekrar edeceği bilinen durumlarda kullanılır.
            - While döngüsü: Belirli bir koşul sağlandığı sürece çalışır. Koşul başlangıçta kontrol edilir.
              Kaç kez tekrar edeceği bilinmeyen durumlarda kullanılır.
        */

        // 2. Soru: 1'den 10'a kadar olan sayıları ekrana yazdıran bir for döngüsü yazın.
        Console.WriteLine("1'den 10'a kadar olan sayılar:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine(); // Yeni satıra geç

        // 3. Soru: Kullanıcıdan alınan bir sayıya kadar olan sayıların toplamını hesaplayan bir program yazın.
        Console.Write("\nBir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        int toplam = 0;

        for (int i = 1; i <= sayi; i++)
        {
            toplam += i;
        }
        Console.WriteLine("1'den " + sayi + "'e kadar olan sayıların toplamı: " + toplam);

        // 4. Soru: Kullanıcıdan bir sayı alıp tek mi çift mi olduğunu bulan bir C# programı yazın.
        Console.Write("\nBir sayı girin (tek/çift kontrolü): ");
        int tekCiftSayi = Convert.ToInt32(Console.ReadLine());

        if (tekCiftSayi % 2 == 0)
        {
            Console.WriteLine(tekCiftSayi + " çift bir sayıdır.");
        }
        else
        {
            Console.WriteLine(tekCiftSayi + " tek bir sayıdır.");
        }

        // 5. Soru: Girilen bir sayının pozitif, negatif veya sıfır olup olmadığını belirleyen bir program yazın.
        Console.Write("\nBir sayı girin (pozitif/negatif/sıfır kontrolü): ");
        int pozitifNegatifSayi = Convert.ToInt32(Console.ReadLine());

        if (pozitifNegatifSayi > 0)
        {
            Console.WriteLine(pozitifNegatifSayi + " pozitif bir sayıdır.");
        }
        else if (pozitifNegatifSayi < 0)
        {
            Console.WriteLine(pozitifNegatifSayi + " negatif bir sayıdır.");
        }
        else
        {
            Console.WriteLine("Girilen sayı sıfırdır.");
        }
    }
}
