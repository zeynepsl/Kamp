using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //metot yazıyoruz c# da
        //syntax sözdizim
        //naming convention - isimlendirme kuralı
        public void Ekle(Urun urun)
        //metot parametre alıyor, tipi Urun
        //bu metotta urunun adını yazdırıyoruz
        //Urun class ı içinde ilgili elemanları tutar
        {
            //sen sepete ekleye bastığında "bana ne ekleyeceğeni söyle" metoda vermen lazım == parametre
            Console.WriteLine("sepete eklendi : " + urun.Adi);
        }

        //bu çok kullanılıyor ama yanlış bir kullanım
        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        //bana urunun adını vs verki  bu 3ünü birden veritabanına ekleyeyim
        {

        }

    }
}

