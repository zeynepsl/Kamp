using System;

namespace InterfaceBestEngineer
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            /*interface ler referans tiplidir
             * new CustomerManager(); dediğşn anada bellkete heapte CustomerManager ın bir refereans değeri olşuyor
             * interfac eler onu implemente den class ın referan s numarsını tutabşlirler
             * 
             */
            customerManager.Add();
            //customermanager ın referans numarasını gidecek

            IPersonManager studentManager = new StudentManager();

            ProjectManager projectManager = new ProjectManager();
            //projectManager.AddStudent(studentManager);
            //projectManager.AddCustomer(customerManager);
            //peki niye böyle yapmıyoruz (her birini tek tek çağır dme ama çok yanlış)
            //niye merkezi bir yönetim isitiyoruz
            //çünkü gerçek haytta 1 neseneyle değil 1den fazla nesneyale çalşıyoruz
            projectManager.Add(new CustomerManager());
                //add ıperson.. türünde bir şwy istiyor en tek başın aIPers.. göneremzsin o interface ama referansının tutmuş IPersonManagerıYollayabilirsin
                //bu yazılımda değişimi sağladı 
        }
    }

    class PersonManager
        //implemented operation - tamamlanmış operasyon, implmente edilmiş içi doldurulmuş
    {
        public void Add()
        {
            Console.WriteLine("added");
        }
    }

    interface IPersonManager
        //unimplemented operation
        //interface üyeleri dışarıdan erişeilebilir olmalıdır
        //defaultu punlic
        //BUrada metodun içini doldurmadım
    {
        //interfac ein içindeki bu add her yerde ortak 
        void Add();
        //void Add(); == bu imza
        //bu metodun içi interface i implemente eden her class için farklı olacak
    }

    class CustomerManager : IPersonManager
        //CustomerManager IPeeson içindeki operrs-asyonları yazmak zorunda artık
        //o metotların içine şstediğini yzabşlir
        //bu bir Ipersonmanager
    {
        public void Add()
        {
            //musteri ekleme ili ilgili kodlar
            Console.WriteLine("müşteri eklendi");
        }
    }

    class StudentManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("öğrenci eklendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
            //implemente edilen interface implemnet edişlen tüm classların referansınıtutar
            //o yüzden buraya parametreye implmente edilen interface i yazabilirm
            //ben CustomerManager ın referansını yollayabilirm
            //benden IPersonManager istiyor
        {
            //public void Add(CustomerManager customerManager) burada sadece customer gönderebilirsin

            
            personManager.Add();
        }

        //public void addstudent(studentmanager studentmanager)
        //{
          //  studentmanager.add();
        //}
    }


}
