using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService
    //database... sen Ilogg.. alternatifisin
    //interface i implemente ettiğim için reefrean avantajından yaralandım
    {
        public void Log()
        {
            Console.WriteLine("dosyaya loglandı");
        }
    }
}
