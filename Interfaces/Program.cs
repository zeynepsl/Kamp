using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo();
            //elimizde bir veri var bütün veri tabanlarına atmak istiyoruz
            //ne yapıcaz

            ICustomerDal[] customerDals = new ICustomerDal[2]
            { 
                new SqlServerCustomerDal(), new OracleCustomerDal() 
            };
            //classı kullanabilmek için new lemeleyiz
            //Icustomer türünde 2 elemanlı array tanımladık

            foreach(var customerDal in customerDals)
            {
                customerDal.Add();
            }

            //artık yeni bir veritabanı ekelrsen sorun omaz

            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();

            //Customer customer = new Customer()
            //{
            //    Id = 1,
            //    FirstName = "zeynep",
            //    LastName = "salman",
            //    Address = "bursa"
            //}; böyle de olabilirdi Add in imzasına sadece customer yazardık
            personManager.Add(new Customer { Id = 1, FirstName = "zeynep", LastName = "salman", Address = "bursa" });

            Student student = new Student()
            {
                Id = 1,
                FirstName = "zeynep",
                LastName = "salman"
            };
           // personManager.Add(student);
            //bu kızdı çünkü Add benden Customer türünde bir şey bekliyor amam ben ona Student tipinde bir veri göndersim
            //AMA Add in İmzasoını Add(IPerson person) yaparasan hepsini gönderebilirsin
            //ister customer ister student gönder
            //bu şekilde olunca doğal olarak Add metodunu içinden sadece IPerson aryüzündeki özelliklere erişeceksin
        }
    }

    interface IPerson//soyut nesne tek başına hiçbir anlama ifade eetmz
        //interface yazımı : public vs olmaz
        //interface abstract sınıflar new lenemez
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        //artık bu özellikleri onu implemente eden class ın içinde yzamak zorundayız
    }

    class Customer : IPerson
    //bunlarda somut nesne
    //IPerson da tanımlı her şey burada da
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName);
        }
         
    }
}
