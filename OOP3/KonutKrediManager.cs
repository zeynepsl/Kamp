using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : IKrediManager
    //KonutKredi.. KrediManager dır
    {
        public void Hesapla()
        {
            Console.WriteLine("konut kredisi hesaplandı");
        }
    }
}
