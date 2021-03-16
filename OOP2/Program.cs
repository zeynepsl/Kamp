using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //SOYUTLAMAY -I ÇOK İYİ BİL
            //OOP ÇOK İYİ BİL
            //İNŞAALLAH İŞSİZ KALMAZSIN

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "1234";
            musteri1.Adi = "zey";
            musteri1.Soyadi = "sal";
            musteri1.TcNo = "123";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "567";
            musteri2.SirketAdi = "kodlama";
            musteri2.VergiNo = "666";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            /*MUsteri, GercekMusteri ve TuzelMusteri yi tutabiliyor
             * new görürsen şunu anla == bellekte bir referans no
             * Musteri classı hem GErcekMusterin nin  referansını hem TuzelMUsteri nin referansını tutabiliyor
             * 
             */

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
            //musteri3 ve 4 ü gönderebilirm çünkü benden 
            /*Musteri classı hem GErcekMusterin nin  referansını hem TuzelMUsteri nin referansını tutabiliyor
             * olay tamamen referans tip,
             * MUsteri sınıfının (base temel sınıfının) onu inherit eden TuzelM GercekM class larını referansını tutabilmesi
             */

        }
    }
}
