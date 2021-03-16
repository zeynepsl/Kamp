using System;

namespace ClassesOdev5
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Sony WH-CH510 Bluetooth Kulak Üstü Kulaklık", 299.00, 20, 351.77, 419);
            //kurucu fonksiyona ilk değerleri gönderiyoruz ve kurucu fonksiyon değer ataması yapıyor

            Product product2 = new Product("Sony WH-1000XM3B Gürültü Önleyici Kulaklık", 2299.00, 15, 2554.00, 160);

            Product[] products = new Product[] { product1, product2 };

            Console.WriteLine("Ürünün Adı \t\t\t\t Ürünün Fiyatı \t Ürünün İndirim Oranı \t Ürünün İndirimden Önceki Fiyatı \t Ürüne YApılan Yorum Sayısı");

            Console.WriteLine("for döngüsü ile : ");
            for(int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].urunAdi + " \t " + products[i].urunFiyati + " \t\t " + products[i].indirimOrani + " \t\t " +
                    products[i].indirimdenOncekiFiyati + " \t\t\t\t " + products[i].uruneYapilanYorumSayisi);
            }


            Console.WriteLine("foreach döngüsü ile : ");
            foreach (var product in products)
            {
                Console.WriteLine(product.urunAdi + " \t " + product.urunFiyati + " \t\t " + product.indirimOrani + " \t\t "+ 
                    product.indirimdenOncekiFiyati + " \t\t\t\t " + product.uruneYapilanYorumSayisi);
            }


            Console.WriteLine("while döngüsü ile : ");
            int j = 0;
            while(j < products.Length)
            {
                {
                    Console.WriteLine(products[j].urunAdi + " \t " + products[j].urunFiyati + " \t\t " + products[j].indirimOrani + " \t\t " +
                        products[j].indirimdenOncekiFiyati + " \t\t\t\t " + products[j].uruneYapilanYorumSayisi);
                    ++j;
                }
            }

        }
    }

    class Product
    {
        public string urunAdi { get; set; }
        public double urunFiyati { get; set; }
        public int indirimOrani { get; set; }
        public double indirimdenOncekiFiyati { get; set; }
        public int uruneYapilanYorumSayisi { get; set; }

        public Product(string ilkUrunAdi, double ilkUrunFiyati, int ilkİndirimOrani, double ilkİndirimdenOncekiFiyati, int ilkUruneYapılanYorumSayisi)
        {
            urunAdi = ilkUrunAdi;
            urunFiyati = ilkUrunFiyati;
            indirimOrani = ilkİndirimOrani;
            indirimdenOncekiFiyati = ilkİndirimdenOncekiFiyati;
            uruneYapilanYorumSayisi = ilkUruneYapılanYorumSayisi;
        }
    }
}
