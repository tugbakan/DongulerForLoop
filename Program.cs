//Ekrana girilen sayıya kadar olan tek sayıları ekrana yazdır.
using System.Runtime.InteropServices;

Console.WriteLine ("Lütfen bir sayı giriniz.");
int sayac = int.Parse(Console.ReadLine());

for (int i = 1; i <= sayac; i++)
{
    if (i%2==1)
    {
        Console.Write (i);
    }
} 

//1-1000 arasındaki tek ve çift sayıların toplamını ekrana yazdır.
int tekToplam=0;
int ciftToplam=0;

for (int i = 1; i <= 1000; i++)
{
    if(i%2==1)
    {
        tekToplam+=i;
    }
    else
    {
        ciftToplam+=i;
    }
}
    Console.WriteLine("Çift toplam:" + ciftToplam);
    Console.WriteLine("Tek toplam:"+ tekToplam);

    //break, continue

    for (int i = 1; i < 10; i++)
    {
        if(i==4)
            break;
            Console.WriteLine(i);
    }
    for (int i = 1; i < 10; i++)
    {
        if(i==4)
            continue;
            Console.WriteLine(i);
    }
 /*   for (;;) //Bu şekilde sonsuz bir döngü olur.
      {
        if(i==4)
            continue;
            Console.WriteLine(i);
      } */
