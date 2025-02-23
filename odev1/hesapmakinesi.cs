using System;

class Program
{
    static void Main()
    {
        double sayi1, sayi2;
        char islem;

        // Birinci sayıyı al ve kontrol et
        Console.Write("Birinci sayıyı giriniz: ");
        while (!double.TryParse(Console.ReadLine(), out sayi1))
        {
            Console.WriteLine("Hata: Geçersiz bir sayı girdiniz. Lütfen tekrar deneyin.");
            Console.Write("Birinci sayıyı giriniz: ");
        }

        // İkinci sayıyı al ve kontrol et
        Console.Write("İkinci sayıyı giriniz: ");
        while (!double.TryParse(Console.ReadLine(), out sayi2))
        {
            Console.WriteLine("Hata: Geçersiz bir sayı girdiniz. Lütfen tekrar deneyin.");
            Console.Write("İkinci sayıyı giriniz: ");
        }

        // İşlemi al ve kontrol et
        Console.Write("Yapmak istediğiniz işlemi seçiniz (+, -, *, /): ");
        while (!char.TryParse(Console.ReadLine(), out islem) || !IsValidOperation(islem))
        {
            Console.WriteLine("Hata: Geçersiz bir işlem seçtiniz. Lütfen +, -, *, / karakterlerinden birini girin.");
            Console.Write("Yapmak istediğiniz işlemi seçiniz (+, -, *, /): ");
        }

        double sonuc = 0;
        bool gecerliIslem = true;

        switch (islem)
        {
            case '+':
                sonuc = sayi1 + sayi2;
                break;
            case '-':
                sonuc = sayi1 - sayi2;
                break;
            case '*':
                sonuc = sayi1 * sayi2;
                break;
            case '/':
                if (sayi2 != 0)
                    sonuc = sayi1 / sayi2;
                else
                {
                    Console.WriteLine("Hata: Sıfıra bölme yapılamaz.");
                    gecerliIslem = false;
                }
                break;
        }

        if (gecerliIslem)
            Console.WriteLine($"Sonuç: {sonuc}");
    }

    // Geçerli işlem karakterlerini kontrol eden yardımcı metot
    static bool IsValidOperation(char islem)
    {
        return islem == '+' || islem == '-' || islem == '*' || islem == '/';
    }
}