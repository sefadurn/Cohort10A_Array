// 1 - 10 adet tam sayı verisi alacak bir dizi tanımlanıyor
int[] sayilar = new int[10];

// 2 - for döngüsü ile diziyi kullanıcıdan veri alarak doldurma
for (int i = 0; i < sayilar.Length; i++)
{
    Console.Write($"{i + 1}. sayıyı girin: ");
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
}

// 2 - foreach döngüsü ile diziyi ekrana yazma
Console.WriteLine("\nGirdiğiniz 10 sayı:");
foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);
}

// 3 - Yeni bir sayı alınıyor ve 11 elemanlı yeni diziye aktarılıyor
Console.Write("\n11. sayıyı girin: ");
int yeniSayi = Convert.ToInt32(Console.ReadLine());

// 11 elemanlı yeni dizi oluşturuluyor
int[] yeniDizi = new int[11];

// Eski dizinin elemanları yeni diziye kopyalanıyor
for (int i = 0; i < sayilar.Length; i++)
{
    yeniDizi[i] = sayilar[i];
}

// 11. eleman ekleniyor
yeniDizi[10] = yeniSayi;

// 4 - Dizi büyükten küçüğe sıralanıyor:
// önce küçükten büyüğe sıralanır
Array.Sort(yeniDizi);

// sonra ters çevrilerek büyükten küçüğe hale getirilir
Array.Reverse(yeniDizi);

// 4 - Sıralanmış diziyi ekrana yazdır
Console.WriteLine("\nBüyükten küçüğe sıralı dizi:");
foreach (int sayi in yeniDizi)
{
    Console.WriteLine(sayi);
}