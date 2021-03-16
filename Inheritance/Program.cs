using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[2]
            {
                new Person{ Id=1, Name="zey"},
                new Customer{Id=2, Name="tu", city="sevdenur"}
            };

            foreach (var person in people)
            {
                Console.WriteLine(person.Name);
            }

        }
    }

    class Person
        /*interface tek başına bir anlaö-m ifade etmiyordu 
         * person ın tek başın aanlam var
         * ama ana class dan ben nesne türetebilirm
         */
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Customer : Person
        //customer ın ebeveyni person 
        //customer ın şu an 3özelliği var
    {
        public string city { get; set; }
    }

    //AYRICA BİR CLASS IN BİR BABASI OLUR
    //INTERFACE DEN FARK BİR CLASS I BİR KERE INHERIT EDEBİLİRSİN
    //varsa ONCE INHERİTANCE SONRA INTERFACE(LER) YAZILIR




}
