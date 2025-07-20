/*
 Bu pratikte aşağıdaki 4 aşamayı kodlamanız isteniyor.

1 - 10 adet tam sayı verisi alacak bir dizi tanımlayınız.

2 - Bu dizinin elemanlarını bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazınız.

3 - Bu diziye kullanıcıdan alınan yeni bir değeri ekleyiniz (11. eleman olarak)

4 - Bu diziyi büyükten küçüğe ekrana yazdırınız.

*/

int[] dizi1 = new int[10];  // 10 adet tam sayi tutacak bir dizi tanımladık.

for (int i = 0; i < dizi1.Length; i++)  // For döngüsü ile diziyi otomatik olarak doldurduk.
{
    dizi1[i] = i + 1;  // 1'den 10'a kadar sayilar atanıyor.

}

foreach(int i in dizi1)
{
    Console.WriteLine(i);
}

Console.Write("11.sayiyi giriniz: ");
int yeniSayi = Convert.ToInt32(Console.ReadLine());

int[] dizi2 = new int[11];  // Yeni, 11 elemanli bir dizi tanımladık.

for(int i =0;i <dizi2.Length;i++)
{
    dizi2[i] = dizi1[i];

}
dizi2[10]= yeniSayi;   // Kullanıcının girmiş olduğu sayi 11.eleman olarak atanıyor.