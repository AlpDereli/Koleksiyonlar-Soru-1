// See https://aka.ms/new-console-template for more information
using System.Collections;
ArrayList asalliste = new ArrayList();
ArrayList normliste = new ArrayList();
for (int i = 0; i <20; i++)
{
    Console.WriteLine("Sayi Degeri Giriniz: ");
    string strsayi = Console.ReadLine();
    bool b = int.TryParse(strsayi, out int sayi);
    while(!b || 0>sayi)
    {
        Console.WriteLine("Girilen Deger Gecersiz");
        Console.WriteLine("Sayi Degeri Giriniz: ");
        strsayi = Console.ReadLine();
        b = int.TryParse(strsayi, out sayi);
    }
    int kontrol = 0;
    if (sayi < 2)
    {
        normliste.Add(sayi);
    }
    else
    {
        for (int a = 2; a<sayi; a++)
    {
        if  (sayi%a==0)
        {
            kontrol+=1;
        }
    }
    if (kontrol == 0)
    {
        asalliste.Add(sayi);
    }
    else
    {
        normliste.Add(sayi);
    }
    } 
}
Console.WriteLine("Girdiginiz Asal Sayilar: ");
asalliste.Sort();
asalliste.Reverse();
double toplam = 0;
foreach(int p in asalliste)
{
    toplam += p;
    Console.WriteLine(p);
}
Console.WriteLine("Bu Dizide "+asalliste.Count+ " adet eleman var");
Console.WriteLine("Bu listenin ortalaması: " + toplam/asalliste.Count);

Console.WriteLine("Girdiginiz Asal Olmayan Sayilar: ");
normliste.Sort();
normliste.Reverse();
toplam = 0;
foreach(int p in normliste)
{
    toplam += p;
    Console.WriteLine(p);
}
Console.WriteLine("Bu Dizide "+normliste.Count+ " adet eleman var");
Console.WriteLine("Bu listenin ortalaması: " + toplam/normliste.Count);

Console.ReadLine();
