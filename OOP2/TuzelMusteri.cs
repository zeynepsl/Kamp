using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //coorporate
    //miras inheritance
    //tuzelMusteri bir müşteridir demek bu
    /*TuzelMuteri nin ebeveyni Musteri
     * musteri de olan her şey TuzelMusteri de kabul edilir
     * TuzelMUsteri inherits || extends Musteri Class ı
     */
    class TuzelMusteri:Musteri
        //bu özellik class ı
        //bu varlık entity 
        //bu class ın içinde metot olmaz
    {
        //sadece ona ait olan özellikler
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
