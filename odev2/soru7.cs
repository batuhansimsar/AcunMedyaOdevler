string[] dizi = { "elma", "armut", "muz" };

        // Dizinin boyutunu 5 yapalım (önceki elemanlar korunur, yeni eklenenler null olur)
        Array.Resize(ref dizi, 5);

        // Yeni elemanlar ekleyelim
        dizi[3] = "çilek";
        dizi[4] = "karpuz";

        Console.WriteLine("Genişletilmiş Dizi:");
        foreach (string eleman in dizi)
        {
            Console.WriteLine(eleman);
        }
