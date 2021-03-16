using System;

namespace Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullaniciAdi = "";
            string sifre = "";
            Console.WriteLine("kullanıcı adını giriniz : ");
            kullaniciAdi = Console.ReadLine();
            Console.WriteLine("şifreyi giriniz: ");
            sifre = Console.ReadLine();
            string durum = (kullaniciAdi == "zeynep" && sifre == "123") ? "Sisteme giriş yapıldı":"Kullanıcı adı veya şifre hatalı";
            Console.WriteLine(durum);
        }
    }
}
