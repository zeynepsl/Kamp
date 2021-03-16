using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //individual
    //gerçekMusteri de bir müşteridir


    //oop2 referans tutucu mu??
    class GercekMusteri:Musteri
    {
        //sadece ona ait olan özellikler
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }

    }
}
