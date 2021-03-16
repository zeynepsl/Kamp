using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDEmo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[2]
            {
                new Manager(),
                new Robot()
            };//manager ve robot için çalışma işini yaptım

            //bütün workerlaı gezip çalış emri
            //bütün çalışnlara çalış emrini verelim
            foreach (var worker in workers)
            {
                worker.Work();
            }

            //yeme için izin vericez
            IEat[] eats = new IEat[1]
            {
                new Manager()
            };

            //ilgili interface ii implemente eden nesnekeri çağıracım
            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }

      

        
       
    }

    //interface i doğru planalamalıyız
    //solid 
    //interface segregation

    interface IWorker
    {
        //bir şirketteki bütün çalışanlar ne yapar
        //3 tip çalışan var
        void Work();
    }
    interface IEat
        //YYyemek ile ilgili başka operasyonlar varsa hepsi için interface
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat,ISalary
        //bir class 1 den fazla interface i implemente edebilir/uygulayabilir
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Robot : IWorker
        //bu sadece çalışır
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}

