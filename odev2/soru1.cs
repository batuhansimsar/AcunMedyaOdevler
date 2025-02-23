Console.WriteLine("Bir sayı giriniz: ");

string number = Console.ReadLine();
int total =0;
for (int i = 0; i < number.Length; i++)
{
    if (number[i] =='-' || number[i] =='+')
    {
        continue;
    }
    total += int.Parse(number[i].ToString());
}
Console.WriteLine("Girilen sayının basamaklarının toplamı ");
Console.WriteLine(total);
