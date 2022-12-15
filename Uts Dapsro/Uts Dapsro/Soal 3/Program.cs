using System;

namespace DasproUTS
{
    class program
    {
        static void Main(string[] args)
        {
            int denda = 0;
            int hari = 0;
            Console.WriteLine("Lamanya telat mengembalikan buku");
            hari = Convert.ToInt32(Console.ReadLine());
            if(hari > 30)
            {
                denda = (hari - 30) * 30000 + 50000 + 400000;
                Console.WriteLine("keanggotaan dibatalkan");
                Console.WriteLine("dan");
                Console.WriteLine("didenda : Rp "+ denda);
            }
            else if(hari > 10)
            {
                denda = (hari - 10) * 20000 + 50000;
                Console.WriteLine(" total denda : Rp "+ denda);   
                
            }
            else if(hari > 5)
            {
                denda  = hari * 10000;
                Console.WriteLine("Denda Keterlambatan :Rp "+ denda);
                
            }
            else
            {
                Console.WriteLine("tidak ada denda");
            }
            Console.ReadKey();
        }
    }
}