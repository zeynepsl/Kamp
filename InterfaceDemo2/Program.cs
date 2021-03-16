using System;

namespace InterfaceDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonManager employee = new Employee();
            IPersonManager student = new Student();

            Manager manager = new Manager();
            manager.Add(employee);
            manager.Add(student);

        }
    }

    interface IPersonManager
    {
        void Add();
        void Update();

    }

    class Employee : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("çalışan eklendi");
        }

        public void Update()
        {
            Console.WriteLine("çalışan güncellendi");
        }
    }

    class Student : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("öğrenci eklendi");
        }

        public void Update()
        {
            Console.WriteLine("öğrenci güncellendi");
        }
    }

    class Manager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }

}