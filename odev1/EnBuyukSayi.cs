using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci sayıyı giriniz: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci sayıyı giriniz: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Üçüncü sayıyı giriniz: ");
        double sayi3 = Convert.ToDouble(Console.ReadLine());

        double enBuyuk;

        if (sayi1 >= sayi2 && sayi1 >= sayi3)
        {
            enBuyuk = sayi1;
        }
        else if (sayi2 >= sayi1 && sayi2 >= sayi3)
        {
            enBuyuk = sayi2;
        }
        else
        {
            enBuyuk = sayi3;
        }

        Console.WriteLine($"En büyük sayı: {enBuyuk}");
    }
}
