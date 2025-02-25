using System;
using System.Linq; // OrderBy için gerekli

class Program
{
    static void Main()
    {
        Console.Write("Bir cümle giriniz: ");
        string cumle = Console.ReadLine(); // Kullanıcıdan cümle al

        string[] kelimeler = cumle.Split(' '); // Boşluklara göre kelimeleri diziye ayır

        Array.Sort(kelimeler); // Alfabetik sıralama

        Console.WriteLine("\nAlfabetik sırayla kelimeler:");
        foreach (string kelime in kelimeler)
        {
            Console.WriteLine(kelime);
        }
    }
}

    
