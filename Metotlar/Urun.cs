using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class Urun
    {
        //benim için bir şeyin ürün olabilmesi için çeşitli özellikleri barındırabilmesi lazım
        //int te nasıl tamsyaı tutuyorsam
        //class için de de birden fazla eleamanı tutabilirm
        //class bir bilgiyi değilde(int string gibi değil de) o nesneyi tanımlayan birden fazla bilgiyi içine yazabildiğimiz yapı
        //class: içinde istediğin özellikleri barındıran yapı
        //urunu anlatan veri tipi mevcut
        //urun aşağıdakilerin hepsini içeren bir tip 
        //property-- özellikler
        public int Id { get; set; }
        public string Adi { get; set; }
        public int Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int stokAdedi { get; set; }



    }
}
