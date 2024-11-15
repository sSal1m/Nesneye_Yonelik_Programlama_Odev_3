using System.Collections;

/* Soru-1 Foreach Döngüsü ile Liste Elemanlarını Yazdırma */

ArrayList SayiList = new ArrayList();

for (int i = 1; i < 10; i++)
{
    SayiList.Add(i);
}

Console.WriteLine("***** Soru-1 *****\n");

foreach (int Cikti in SayiList)
{
    Console.WriteLine(Cikti);
}



/* Soru-2 Hazır Metod Kullanımı */
Console.WriteLine("\n\n\n");
Console.WriteLine("***** Soru-2 *****\n");
Console.Write("Bir Cümle Giriniz: ");
string Cümle = Console.ReadLine();
string[] Kelime = Cümle.Split(' ');
Console.WriteLine("Girilen Bu Cümledeki Kelime Sayısı: " + Kelime.Length);



/* Soru-3 ArrayList ile Alfabetik Sıralama */
Console.WriteLine("\n\n\n");
Console.WriteLine("***** Soru-3 *****\n");

ArrayList isim = new ArrayList();

for (int i = 1; i < 6; i++)
{
    Console.WriteLine("İsim Gir:");
    isim.Add(Console.ReadLine());
}

isim.Sort();
Console.WriteLine("\n Girilen 5 Adet İsmin Alfabetik Sıralaması: ");
foreach (string siralama in isim)
{
    Console.WriteLine(siralama);
}



/* Soru-4 For Döngüsü ile Fibonacci Serisi */
Console.WriteLine("\n\n\n");
Console.WriteLine("***** Soru-4 *****\n");

Console.WriteLine("Fibonacci Sayı Dizisinden Hesaplanmasını İstediğiniz Sayı Adetini Giriniz: ");
int sayı = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n Fibonachi Dizisinin İlk " + sayı + " Sayısı: ");
int x = 0, y = 1, z;
for (int i = 0; i < sayı; i++)
{
    Console.WriteLine(x + " ");
    z = x + y;
    x = y;
    y = z;
}



/* Soru-5 While Döngüsü ile Tahmin Oyunu */
Console.WriteLine("\n\n\n");
Console.WriteLine("***** Soru-2 *****\n");

Random random_sayı = new Random();
int gerçek_sayı = random_sayı.Next(1, 3);
int W = 0;
while (W < 1)
{
    Console.WriteLine("1 ile 50 Arasında Bir Sayı Giriniz: ");
    int girilen_sayi = Convert.ToInt32(Console.ReadLine());

    if (girilen_sayi != gerçek_sayı)
    {
        Console.WriteLine("Bilemediniz Tekrar Deneyiniz\n");
    }

    else
    {
        Console.WriteLine("Bravo Doğru Cevap.");
        W = 1;
    }

}

/* Soru-6 Do While Döngüsü ile Basit Hesap Makinesi */
Console.WriteLine("\n\n\n");
Console.WriteLine("***** Soru- *****\n");

string aksiyon;
do
{
    Console.WriteLine("İşlem Türünü Seçiniz ( +, -, /, *) \n [çıkmak için 'çıkış' yazınız]");
    aksiyon = Console.ReadLine();

    if (aksiyon == "çıkış")
    {
        break;
    }

    else
    {
        Console.WriteLine("Birinci Sayıyı Giriniz:");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("İkinci Sayıyı Giriniz:");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        switch (aksiyon)
        {
            case "+":
                Console.WriteLine("Sonuç: " + (sayi1 + sayi2));
                break;

            case "-":
                Console.WriteLine("Sonuç: " + (sayi1 - sayi2));
                break;

            case "*":
                Console.WriteLine("Sonuç: " + (sayi1 * sayi2));
                break;

            case "/":
                if (sayi2 != 0)
                {
                    Console.WriteLine("Sonuç: " + (sayi1 / sayi2));
                }

                else
                {
                    Console.WriteLine("Tanımsız (bölü sıfır hatası)");
                }
                break;

            default:
                Console.WriteLine("Geçerli Değerler Giriniz");
                break;
        }
    }
}
while (true);



/* Soru-7 For ve While Döngüsü ile Sayı Toplama Oyunu */
Console.WriteLine("\n\n\n");
Console.WriteLine("***** Soru-7 *****\n");

int p = 2;
int toplam = 0;
List<int> _sayilar_ = new List<int>();
while (p > 1)
{
    Console.WriteLine("\nPozitif Tam Sayı Giriniz...\n Sonlandırmak için '0' giriniz.");
    int _girilen_sayi_ = Convert.ToInt32(Console.ReadLine());

    if (_girilen_sayi_ == 0)
    {
        Console.WriteLine("Sonlandırıldı.");
        Console.WriteLine("Girilen Tüm Sayıların Toplamı: " + toplam);
        p = 1;
    }
    else
    {
        _sayilar_.Add(_girilen_sayi_);
        toplam = toplam + _girilen_sayi_;
    }
}

Console.WriteLine("\nGirilen Sayılar:");
for (int i = 0; i < _sayilar_.Count; i++)
{
    Console.WriteLine("Sayı " + (i + 1) + " = " + _sayilar_[i]);
}