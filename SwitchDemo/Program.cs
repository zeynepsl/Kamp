using System;

namespace SwitchDemo
{
    
    class Program
    {
        public static void Main()
        {
           /* int ifade = 1;
            switch (ifade)
            {
                case 1:
                    Console.WriteLine("case 1 çalıştı");
                    break;

                case 2:
                    Console.WriteLine("case 2 çalıştı");
                    break;

                default:
                    Console.WriteLine("eşleşme bulunamadı");
                    break;
            }*/

            int i = 0; // initialization

            while (i < 10) // condition
            {
                Console.WriteLine("i = {0}", i);

                i++; // increment
            }

        }
    }
}
