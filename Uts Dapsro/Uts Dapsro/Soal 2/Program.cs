using System;

namespace DasproUTS
{
    class program
    {
        static void Main(string[] args)
        {
            int tebakan = 0;
            Random rng = new Random();
            int tebakanBenar = rng.Next(1, 100);
            while (tebakan != tebakanBenar)
            {
                Console.WriteLine(" Silahakan tebak angka yang telah dipilih komputer dari  1-100");
                tebakan = Convert.ToInt32(Console.ReadLine());
                if(tebakan < tebakanBenar)
                {
                    Console.WriteLine("Tebakan anda kurang tepat");
                    Console.WriteLine("Coba anda tebak dengan angka yang lebih tinggi!!");
                }
                else if(tebakan > tebakanBenar)
                {
                    Console.WriteLine("Tebakan anda kurang tepat");
                    Console.WriteLine("Coba anda tebak dengan angka yang lebih rendah!!");
                }
                else
                {
                    Console.WriteLine("Tebakan Anda Tepat!!");
                    Console.WriteLine("Terimakasih telah bermainn, sampai jumpa nanti");
                    Console.WriteLine("Byee...");
                    Console.ReadKey();
                }
            }
        }
    }
}
