using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacKrediManager : IKrediManager
    //her kredinin kendine özgü "Hesapla" işi vardır
    {
        public void Hesapla()
        {
            Console.WriteLine("ihtiyaç krdisi hesaplandı");
        }
    }
}
