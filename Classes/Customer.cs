using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
        //bu özellik classı
        //property
    {
        //field
        public string LastName;

        //property ise bunlar
        //bir classı anlatan özellik tanımlayaxaksak property olarak tanımlarız
        public int Id 
        {
            get { return Id; }
            set { Id = value; }
        }
        public string FirstName { get; set; }
        public string City { get; set; }

        //public int Id böylede yazılabilir ama get ve set metotlarını yazmak == encapsulation
    }
}
