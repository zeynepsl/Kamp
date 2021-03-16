using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();//instance oluşturuyoruz
            //konutKrediManager.Hesapla();




            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

            IKrediManager tasitKrediManager = new TasitKrediManager();

            IKrediManager konutKrediManager = new KonutKrediManager();//instance oluşturuyoruz

            /**bunlarda çalışır
             * aynı sonucu alırız
             * interface lerde o interface i implemente eden classın referans numarasını  tutabiliyor
             * şubedeki arkadaşımızın ekranı
             */

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            //new en sonraki kısımlar referans numarası bize lazım olan o

            List<ILoggerService> loggers = new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService() };


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, loggers);
            //başvuru yap:konut kredisine göre, loglamayı veritabanına yap

            //yazılımda sürdürülebilirlik
            //yazılımda yeni iistelkleerel devam ettirilir.

            //bu oop3 seni işe sokacak bilgi

            //yüzlerce kredi var
            //isterse birinii isterse dördünü seöebilir
            //10 tane 1000 tane olabilir
            //aynı veri tütünde belirsiz sayıda veri türü oluşturmak için == params

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager };

           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
