int[] dizi = { 1, 2, 3, 3, 4, 5, 5, 5, 6, 7, 8, 8 };
        int uzunluk = dizi.Length;

        Console.WriteLine("Tekrar eden elemanlar:");

        for (int i = 0; i < uzunluk; i++)
        {
            for (int j = i + 1; j < uzunluk; j++)
            {
                if (dizi[i] == dizi[j])
                {
                    Console.WriteLine(dizi[i]);
                    break;  // Aynı elemanı birden fazla yazdırmamak için çıkıyoruz
                }
            }}
