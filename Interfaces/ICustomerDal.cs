using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal
        //data access layer veri tabanı işlemleri
        //her veri taabnı için kullanacağım operasyonlar farklı :)
    {
        void Add();
        void Update();
        void Delete();

    }

    //bu alttaki ikisi de ICustomerDal

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("sql added");
        }

        public void Delete()
        {
            Console.WriteLine("sql deleted");
        }

        public void Update()
        {
            Console.WriteLine("sql updated");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("oracle added");
        }

        public void Update()
        {
            Console.WriteLine("oracle added");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
            //ekelmem iini yapıcaz ama hagisine göre sql e göre mi oracle a göre mi
            //parametre olarak ICustomerDalı gönderdim :D
        {

        }
    }
}
