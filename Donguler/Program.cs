using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //hoca kursları listelemiş

            //string kurs1 = "yazılım geliştirici yetiştirme kursu";
            //string kurs2 = "parogramalamaya başalnıç";
            //ürün kurs sayısı sabit değil ki gerçek yaşamda, bazen yeri geliyor 200 ürün var
            //liste formatında göstermelisin === diziler
            //ben bu ikisini döngü ile nasıl gezicem
            //yeni bir kurs eklediğimde gelip onun içinde mi kurs ekleme alanı oluşturucam hayırrr
            //array de tutucaz

            //*********************                                                        tek bir stringi değil 1 den fazka stringi aynı anda tutmak istiyorum
            //istediğim kadar kursu tek bir değişken de tutaabilirim
            //tek tek tanımlamak yerine böyle array de tuttuk
            //*********************                                                        değişkenin türü string ddeğil string array
            //dinmaik prgramlama
            //elimizde bir veri var o veriyi dönüyoruz döngüde
            string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kursu", "parogramlamaya başalnıç" };
            //bu kursların ismi vs bir veri kaynağından geliyor gerçek hayattta

            //dizi eleman sırası 0 dan başlar

            //i sayaç, kurs eleman sayısından küçük olduğu sürece döngü ya
            for (int i = 0; i < kurslar.Length; i++)
                //daha genel amaçlar için
            {
                Console.WriteLine(kurslar[i]);
            }
            //intellisense
            //pyhton daki for yapısını foreach ile sağlıyoruz
            //dizi temelli yapıları tek tek dönmeye yarar
            
            //1. dönüşte "yazılım geliştirici .... "  bu çalışır vs......
            //foreach == dizilerin elemanlarını tek tek dolşmaya yarar elemanlarını
            //******************************                                                    her bir dönüşte her bir eleman için kurs isminin kullanıyoruz () a, x yazabilirsin
            //buradaki kurs her bir elemanı fdolaşırken vediğmiz takma isim, aians
            //

            //in kurslar == kursları tek tek dolaş
            //foreach dizilere uygulanır
            foreach (string kurs in kurslar)
                //dziileri kolay dolaşmak şçin kuullanırız
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa  sonu"); 
        }
    }
}
