using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService
        //database... sen Ilogg.. alternatifisin

    {
        public void Log()
        {
            Console.WriteLine("veritabanına loglandı");
        }
    }
}
