int number = 0;
do{
    Console.WriteLine("Lütfen 10 ile 100 arasında bir sayı giriniz: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number<10 || number>=100){
        Console.WriteLine("Girilen sayı 10 ile 100 arasında olmalıdır.");
    }
    else{
        Console.WriteLine("Girilen sayı: "+number);
    }
} while (number<10 || number>=100);
