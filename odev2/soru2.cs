        Console.Write("Lütfen 10 ile 100 arasında bir sayı giriniz: ");
        int number = Convert.ToInt32(Console.ReadLine());

        while (number <= 10 || number >= 100)
        {
            Console.WriteLine("Girilen sayı 10 ile 100 arasında olmalıdır.");
            Console.Write("Lütfen tekrar giriniz: ");
            number = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Girilen sayı: " + number);
