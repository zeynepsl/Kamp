using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{ CategoryId=1, CategoryName="bilg"},
                new Category{ CategoryId=2, CategoryName="tel"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1, ProductName="hp laptop", QuantityPerUnit="32 gb ram", UnitPirice=10000, UnitİnStock=5},
                new Product{ProductId=2, CategoryId=1, ProductName="hp laptop", QuantityPerUnit="32 gb ram", UnitPirice=10000, UnitİnStock=5},
                new Product{ProductId=3, CategoryId=1, ProductName="hp laptop", QuantityPerUnit="32 gb ram", UnitPirice=10000, UnitİnStock=5},
                new Product{ProductId=4, CategoryId=2, ProductName="hp tel", QuantityPerUnit="32 gb ram", UnitPirice=10000, UnitİnStock=5},
                new Product{ProductId=5, CategoryId=2, ProductName="hp tel", QuantityPerUnit="32 gb ram", UnitPirice=10000, UnitİnStock=5},
            };

            Console.WriteLine("algoritmik----------------");

            foreach(var product in products)
            {
                //5000 tl üzerindekileri göstermek istediğinde 
                if (product.UnitPirice > 5000 && product.UnitİnStock>3)
                {
                    Console.WriteLine(product.ProductName);
                }
            }//bu şekilde yazamk uzun iş

            Console.WriteLine("Linq----------------");

            var result = products.Where(p=> p.UnitPirice>5000);
            //p; listeyi gezerken, listenin her elemanına verilen takma isim
            //arka tarafta iterasyon var(döngü)
            //yukarıda yazdığın if in kısa hali
            //result da array tabanlı

            foreach(var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

            GetProducts(products);

        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> FiltereProducts = new List<Product>();
            foreach (var product in products)
            {
                //5000 tl üzerindekileri göstermek istediğinde
                if (product.UnitPirice > 5000 && product.UnitİnStock > 3)
                {
                    FiltereProducts.Add(product);
                }
            }
            return FiltereProducts;
        }
        //gerçek hayatta konsol uygulaması yapmıyorsun ki
        //seçtiğim ürünleri şarta uyanları bir listede tutmam lazım

        //AMA LINQ KULLANIRSAK:
        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPirice > 5000).ToList();
            //buradaki where for each i sağlar her  bir product için
            //Where metodu listemiz içi bir döngü oluşturur, şarta uyanları herbirini yeni listeye atar
            //bu da arka planda bir liste oluşturur ona aktarır
            //ToList: listeye çevirmek için
        }

    }

    class Product
    {
        public int ProductId { get; set; }


        //Category ile bu Class ı nasıl bağlandırabilrim
        //gidip CategoryName yazamam name değiştiğinde benim gidip hepsinde değiştirmem gerekir
        //bu yüzden CategoryId snini vericem
        //category nin mname i ğzerinden değil
        //category nin ıd si üzerinden gideriz
        public int CategoryId { get; set; }

        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPirice { get; set; }
        public int UnitİnStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
