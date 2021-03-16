using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //referan instance oluşturduk
            customerManager.Add();

            Customer customer = new Customer();
            customer.FirstName = "zeynep";//property deki set bloğu çalışır

            Console.WriteLine(customer.FirstName);//get metodu çalışır


        }
    }
}
