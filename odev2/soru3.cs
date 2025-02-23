        List<int> yaslar = new List<int> { 5, 17, 25, 70, 12, 19, 40, 65 };

        foreach (int yas in yaslar)
        {
            string kategori;

            if (yas >= 0 && yas <= 12)
                kategori = "Çocuk";
            else if (yas >= 13 && yas <= 19)
                kategori = "Genç";
            else if (yas >= 20 && yas <= 64)
                kategori = "Yetişkin";
            else
                kategori = "Yaşlı";

            Console.WriteLine($"Yaş: {yas} - Kategori: {kategori}");
        }
