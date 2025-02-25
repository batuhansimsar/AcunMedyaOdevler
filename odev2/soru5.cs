
        string[] dizi = { "adam", "johny", "james", "jane" };
        string bigone = "";
        string small = "";
        for (int i = 0; i < dizi.Length; i++)
        {
            for (int j = i + 1; j < dizi.Length; j++){
                if (dizi[i].Length < dizi[j].Length)
                {
                    bigone = dizi[j];
                }
                else
                {
                    bigone = dizi[i];
                }
            }
        }
        for (int i = 0; i < dizi.Length; i++)
        {
            for (int j = i + 1; j < dizi.Length; j++){
                if (dizi[i].Length > dizi[j].Length)
                {
                    small = dizi[j];
                }
                else
                {
                    small = dizi[i];
                }
            }
        }
        Console.WriteLine(bigone);
        Console.WriteLine(small);
