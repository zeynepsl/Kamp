using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            //class ın örneği
            //string urunAdi = "meyve";
            //string onun veri tipi, ben string ten bir örnek oluşturuyorum

            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };
            //array BİR veri tipinde istediğin kadar veriyi tutan yapı

            foreach (Urun urun in urunler)
            //in runler === dizimi tek tek gez 
            // gelen data tek tek ekrana basılır
            //kodlar urun sayısı kadar dönecek
            // o an dönene takma isim == urun 
            //type safe -- tip güvenli
            //c# ne ile çalışacağımı bilmek istiyorum diyor o yuzden var yerine veri tipini yazdık
            //var arkaplanda Urun tipinde 
            {
                //gerçek hayatta <li></li> arasına yazıyorlistelenecekleri gösteriyor
                //biz şu an backend(arka tarafını ile uğraşıyoruz datayı yönetmeye çalışıyoruz==c# öğreniyoruz
                //konsolu yazılımcı kullanır
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");

            }

            Console.WriteLine("-------Metotlar---------");

            SepetManager sepetManager = new SepetManager();

            //bu metot parametre istiyor
            sepetManager.Ekle(urun1);


            //bunu böyle yapmasaydım bu kodun olduğu her sayfaya gidip değiştirmem gerekicem


            sepetManager.Ekle2("armut", "sarı armut", 12);
            sepetManager.Ekle2("armut", "sarı armut", 12);
            sepetManager.Ekle2("armut", "sarı armut", 12);
            sepetManager.Ekle2("armut", "sarı armut", 12);
            sepetManager.Ekle2("armut", "sarı armut", 12);
            //bu ekel2 metoduna 3 parametre göndermek zorundasın
            //5 farklı sayfadayım
            //yönetim dedi ki ürünün stok adedinin de yazalım dedi
            //ekle2 ye parametre ekledin
            //ve butun sayfaların patladı gidip tek tek değişritmelidisn

            //ama class a propert olarak eklersen hiçbir metodun, sayfan patlamıcak === encapsulation
            //nesnenin bir bütün olamsı
            //urun id , ad, aciklama vs ye sahip

        }
    }
}
