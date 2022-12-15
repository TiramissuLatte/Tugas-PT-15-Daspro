using System;

namespace Dadu
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            GamePlay();
            Outro();
        }

        static void Intro() 
        {
            Console.WriteLine("ADU DADU\n");
            Console.WriteLine("Selamat bergabung ke dalam permainan Adu Dadu");
            Console.WriteLine("Dalam permainan ini para pemain akan bertanding dengan komputer");
            Console.WriteLine("Permainan ini terdiri dari 10 Ronde");
            Console.WriteLine("Setiap ronde para pemain dan komputer masing masing akan melempar satu buah dadu");
            Console.WriteLine("Pemain/Komputer yang mengumpulkan poin terbanyak diakhir ronde akan menjadi pemenang");
        }
        static void GamePlay() 
        {
            int daduKomputer;
            int daduPemain;

            int jumlahRonde = 0;
            int poinKomputer = 0; 
            int poinPemain = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\nTekan tombol apa saja untuk memulai...\n");
                Console.ReadKey();

                jumlahRonde++;
                Console.WriteLine("Ronde " + jumlahRonde);
                daduKomputer = numbGen();
                Console.WriteLine(" Giliran Komputer melempar dadu dan mendapatkan angka " + daduKomputer + ".");
                Console.ReadKey();
                daduPemain = numbGen();
                Console.WriteLine("Giliran Pemain melempar dadu dan mendapatkan angka " + daduPemain + ".");

                if (daduPemain > daduKomputer)
                {
                    poinPemain++;
                    Console.WriteLine("Pemain memenangkan ronde ini!");
                } else if (daduKomputer > daduPemain) {
                    poinKomputer++;
                    Console.WriteLine("Komputer memenangkan ronde ini!");
                } else {
                    Console.WriteLine("Pemain dan Komputer seri!");
                }

                Console.WriteLine("Skor Pemain saat ini: " + poinPemain + " || Skor Komputer saat ini: " + poinKomputer);
                Console.WriteLine("----------------------------------------------------------------------------------");
                Console.ReadKey();
                Console.Clear();
            }

            if (poinPemain > poinKomputer)
            {
                Console.WriteLine("Selamat, pemain memenangkan permainan!");
            } else if (poinKomputer > poinPemain) {
                Console.WriteLine("Sayang sekali, Komputer memenangkan permainan!");
            } else {
                Console.WriteLine("Permainan ini berakhir seri...");
            }
            Console.ReadKey();
        }
        static void Outro() 
        {
            Console.WriteLine("Nama  : Danil zalma hendra putra");
            Console.WriteLine("Prodi : Teknik Informatika S1 A");
            Console.WriteLine("NIM   : 2207112600");
            Console.ReadKey();
        }
        static int numbGen() 
        {
            Random numbGen = new Random();
            int numb = numbGen.Next(1, 7);
            return numb;
        }
    }
}