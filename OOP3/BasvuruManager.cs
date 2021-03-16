using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
        //krediye başvuru alırken
    {
        //method injection
        //bu metodun kullancağı kredimanger türünün ne olacaağnı enjekte ediyoruz
        //başvuru işlemlerinde hangi kredi hangi loglama olduğunu bilmiyoruz
        //sadece aşağıdaki gibi soyut halleri avar ben somut hallerini enjekte ettim

        //loglamam genelde hem veritabanına hem sms yapılır yani birden fazla loglama olur
        //çoğul yollayacağız, o zaman ne yapıcaz:: Lİst
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerService)
        {
            /*başvuran bilgilerini değerlendirme
             * ... 
             * ...
             */

            // KonutKrediManager konutKrediManager = new KonutKrediManager();
            //   konutKrediManager.Hesapla();
            //bu çalışır AMA tüm başvurular konut kredisi üzerinden hesaplanır
            //yazılımcılığın kırlma noktası olabilir
            //design patterblar bunu üzerine kururlu
            //tüm başvurular konut kredisine bağımlı
            //aslında doğru değil

            //bu başvuru hangi krediye göre olacak
            //hepsini tuttabilen biri var imzaya git
            //istersen ihtiyaç istersen tasıt vs vs gönder

            krediManager.Hesapla();
            /*gönderdiğim referarnsın hesaplasını çalıştırdım
             * basvuru kredi bağımsız oldu
             * istersen taşıt gönder
             * taşıt gönderirsen taşıt kredi referansı >> imza
             * taşıt kredinin bellekteki referansındaki hesapla çalışı
             */

            foreach (var loggerService1 in loggerService)
            {
                loggerService1.Log();
            }
            //hangi loglalayıcı seçimmişse sistemde onu logla
            //her bir loglayıcıyı çalıştır
            //tek logger la değil çok logger la çalışıyorum


        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)//bana bir liste ver tütü IkrediManager
        {
            //liste yolladım listedeki her bir elemanı gezdim
            foreach(var kredi in krediler)//her bir krediyi dönecek
            {
                kredi.Hesapla();
                //yukarıda birini hesapladı burada istediğini gönderebilirsin
            }

        }
    }
}
