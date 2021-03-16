using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
        //* / + - yapan metot olacak
    {
        //her sayfada toplamayı ayarı ayrı yapmıcaz çağırıcaz
        //parametre metodun ihtiyacı olan şey
        //topla metodunun 2 tane sayısa ihtiyacı var
        //topla yı kullanabilme için ona 2 tane sayı vermeliyiz
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine(" sonuç : " + toplam);
        }
    }
}
