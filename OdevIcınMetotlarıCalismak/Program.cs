using System;
using System.Linq;

namespace OdevIcınMetotlarıCalismak
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 20;
            int sayi2 = 100;
            static int Ekle(int sayi1, int sayi2)
                //Bu metot int tipinde bir değer döndürüyor
                //çünkü başında int var 
            {
                sayi1 = 30;
                return sayi1 + sayi2;
            }

            Console.WriteLine(Ekle(sayi1,sayi2));
            Console.WriteLine(sayi1);//sayi1 hala 20 dir
            //sayi1 değer tip çünkü
            //değer tiplerde mevzu değişkenin değeri ile ilgilenir
            /*ben ekle(number1) yazdığımda number1 gitmiyor number1 in değeri gidiyor
             * yanı ekle(20) demekle ekle(sayi1) demek apaynı
             * eğerki referans ile göndermek istiyorsam aşağıda
             * 
             */

            static int Ekle(ref int sayi1, int sayi2)
            //Bu metot int tipinde bir değer döndürüyor
            //çünkü başında int var 
            {
                sayi1 = 30;
                return sayi1 + sayi2;
            }

            Console.WriteLine(Ekle(ref sayi1, sayi2));
            //ref keyword == değer tiplerin referans tip gibi kullanılmasını sağlar
            //bellekte 2 tane değişken tanımlanıyo onu yapma
            //sayi1 in referansını kullan

            /*gerçek hayatta nerede
             * kredi hesaplama
             * kredi oranı var indirm kazandı diyelim ki müşteri
             * sayi1 e ihtiyaç varsa veya sayi1 in metotta değişeceğini düşünüyorsan kabul ediyorsan ref olarak gönder
             */

            /*out keyword == değer tipi referans tip gibi göndermek (ref ile mantığı aynı)
             * FARK == refte sayi1 i set etmen gerekiyor, yani bir değeri olmalı
             * outtta böyle bir zorunluluk yok
             * değeri baştan set etme ihtiyacı varsa ref kullanırız
             * böyle bir durum yoksa out
             * 
             * out kullanırsan (ilkk kullandığın an itibariyle)metodun içinde set edilmeli, değişkeni ilk tanımladığında set etmenin bir anlamı getirisi yok out ta
             * 
             
            */

            static int Multiply(int sayi1, int sayi2)
            {
                return sayi1 * sayi2;
            }

            static int Multiply(int sayi1, int sayi2, int sayi3)
            {
                return sayi1 * sayi2 * sayi3;
            }

            //int Multiply(int sayi1, int sayi2, int sayi3) == imzaları farklı(metodun imzası
            /*overload == aşırı yükleme
             * peki ben
             * 10 20 tane sayı toplamak istesem hep overload mı yapıcam
             * 
             */

            static int Ekle2(params int[] number)
            //kaç parametre istiyorsan gönderebilirsin
            //params ile metoda  aynı tipte istediğin kadar parametre gönderebilirsin
            //static int Ekle2(int sayi1, params int[] numbers) böyle de yapabilirsin(önce 1 sayı vs 
            // AMA
            /*Ekle2(1,2,3) deyip gönderirisen sonuç 5 çıkar. çünkü 1, sayi1 e yerleşti ve ben onu hiç kullanmadım 
             *params a denk gelenler 2,3
             *ayrıca params son parametre olmak zorunda, int sayi1 kısmını sona yazamazsın hata verir
             */
            {
                return numbers.Sum();//dizi sayısal olduğu için bütün sayoıları topla sonuucu retut-rn et

            }
            Console.WriteLine(Ekle2(1, 22, 3, 4, 44));


        }
    }
}

ÖZET
    - do not repeat yourself
- void->geriye değer(int, bool, string vs.) döndürmeyen metot tipi.
-return-> metotlarda belirlenen veri tipine göre geriye değer döndüren komut
-ref / out -> değer tiplerinin referans tip gibi kullanılmasına olanak sağlar. eğer gönderdiğimiz değerin metot içerisinde değişmesi öngörülüyorsa kullanılabilir. isiki arasındaki fark : out ile değişkene ilk değer atama zorunluluğu yoktur. ancak gönderilen değişkenin değeri metot içerisinde set edilme zorunluluğu vardır.
-method overloading (aşırı yükleme) -> aynı metodu farklı parametreler ile kullanımı
-params -> parametreleri bir dizi haline getirip kullanıcının istediği kadar parametre ile metodun kullanılmasını sağlar
