using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> liste = new List<string> { "elma", "armut", "muz" };

        // Yeni eleman ekleme
        liste.Add("çilek");
        liste.Add("karpuz");

        // Ters listeyi yazdırma
        liste.Reverse();
        Console.WriteLine("Liste Elemanları:");
        foreach (string eleman in liste)
        {
            Console.WriteLine(eleman);
        }
    }
}
