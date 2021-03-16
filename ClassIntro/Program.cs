using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //alttaki 3satır 1 değişken
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "zeynep";
            //bunun ttipi kurs, 1 den fazkla eleman iöçeriyor içinde, int gibi sring gibi
            //string veya int olarak tanımlamadım class olarak tsnımladım bir class da da o alanları verebiliyorum

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "ayşenur";

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2 };
            //onceki nasıldı : string[] kurslar (içinde sadece string tutabilirsin)
            //böyle yazarsan içinde kurs(kurs objesi) tutabilirsin
            //içiinde kurs tipi veriler
            //içinde kurs nesnesni barındıran kurs array tanımladım

            //gerçek hayatta da böyle

            foreach (var kurs in kurslar)
                //tekrar tekrar dönmeye yarar
                //var kalabilir hangi veri tipindeyse o çalışır
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.Egitmen);

                //ileirde ASP.Net MVC ile beraber veya react veya angular ile bu verileri görselleştirirsin
                //html formatında gösteririsin
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }


        //bizim değişkenimiz bundan önce sadece stringti şu an kurs
        //Kurs un için de 3 özellik var 
    }
}
