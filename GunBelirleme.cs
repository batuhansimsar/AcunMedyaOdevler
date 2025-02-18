using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Günü belirlemek için tarihi giriniz (GG/AA/YYYY): ");
        string input = Console.ReadLine();

        if (DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime tarih))
        {
            string gunIsmi = GunIsmiBelirle(tarih.DayOfWeek);
            Console.WriteLine($"{tarih:dd/MM/yyyy} tarihi {gunIsmi} gününe denk geliyor.");
        }
        else
        {
            Console.WriteLine("Geçerli bir tarih formatı giriniz.");
        }
    }

    static string GunIsmiBelirle(DayOfWeek day)
    {
        switch (day)
        {
            case DayOfWeek.Sunday: return "Pazar";
            case DayOfWeek.Monday: return "Pazartesi";
            case DayOfWeek.Tuesday: return "Salı";
            case DayOfWeek.Wednesday: return "Çarşamba";
            case DayOfWeek.Thursday: return "Perşembe";
            case DayOfWeek.Friday: return "Cuma";
            case DayOfWeek.Saturday: return "Cumartesi";
            default: return "Geçersiz Gün";
        }
    }
}
