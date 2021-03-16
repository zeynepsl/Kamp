using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager
        //operasyonlar tanımlıcaz
        //I ile başlatırız interface olduğunda okunması kolay olsun diye

        //ıkredimanager referans tutacak
        //ve aynı zamanda tüm kredi tiplerinin uygılaması zorunlu olan operasyonları  tutsun diye bu interface i oluşturduk
    {
        public void Hesapla();

        //kredi  türüne göre hesaplamalar oluyor
        //bu benim için tek başına bir anlam ifade etmiyor
        //imzanın aynı olduğu ama içerisisn farklı olduğu durmumlarda bu base de oluşturduğumuz class ı interface olarak oluştururuz 
        //interface benim için bir şablon
        /*bir sınıf bu interface i alırsa uygularsa içindeki bütün metotları yazmak zorunda
         yeni ibr nesne oluşturulurken
        interface == arayüz == şablon
        bu şablona uymalısın

        kötü programcı :
        bunu sınıf yapmak 
        hesaplanın içine if ler koyup bu kredi türü ise şöyle bu kredi türü ise şöyle hesapla demek :((
        interface leri operasyonel metotlarda kullanıyoruz genelde
        cs c# demek
         */

    }
}
