using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen bir şifre girin:");
        string password = Console.ReadLine();

        if (IsPasswordStrong(password))
        {
            Console.WriteLine("Şifre güçlü!");
        }
        else
        {
            Console.WriteLine("Şifre güçlü değil. Lütfen şifrenizi aşağıdaki kurallara göre güçlendirin:");
            Console.WriteLine("- En az 8 karakter uzunluğunda olmalı.");
            Console.WriteLine("- En az bir büyük harf içermeli.");
            Console.WriteLine("- En az bir özel karakter (@, #, $, % gibi) içermeli.");
        }
    }

    static bool IsPasswordStrong(string password)
    {
        // Şifre uzunluğu kontrolü
        if (password.Length < 8)
        {
            return false;
        }

        // Büyük harf kontrolü
        if (!Regex.IsMatch(password, "[A-Z]"))
        {
            return false;
        }

        // Özel karakter kontrolü
        if (!Regex.IsMatch(password, "[@#$%]"))
        {
            return false;
        }

        return true;
    }
}