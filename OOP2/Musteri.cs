"using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Musteri
        //ebeveyn class
    {
        // 2 tür class == özellik, metot
        //burada bir müşteriyi anlatıyoruz dikkat
        public int Id { get; set; }
        public string MusteriNo { get; set; }

        //bu 2 özellik Musteri de ortak

        //public string SirketAdi { get; set; }
        //public string TcNo { get; set; }
        //bunalrı string yapmak == bir veri üzerinde matematiksel işlem yapmıyorsan metinsel olarak planlanır
        //farklı sistemler için veri uyumluluğunda
        //farklı sistemlerde bu sayıların sınırları farklılık gösterebiliyor


        //************
        //bir nesnede bir özellik, değeri kullanmak zorunda değilmişsin gibi gözüküyorsan
        //o alan o nesneye uygun gibi durmuyorsa == soyutlama hatası 

        //2 nesnem var == gerçek müşteri, tüzel müşteri bu ikisi benzer diye
        //birbirinin yerine kullanılamazlar
        //evet ikisi de müşteri ama farklı

        //SOLID yazılım geliştirme prensiplerinden L harfi bu

    }
}
