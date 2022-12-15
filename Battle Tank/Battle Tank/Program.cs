using System;

namespace BattleTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int panjangArena = 5;
            char rumput = '~';
            char tank = 't';
            char hit = 'X';
            char miss = 'O';
            int jumlahTank = 3;

            char[,] playArena = buatRuang(panjangArena, rumput, tank, jumlahTank);

            print(playArena, rumput, tank);

            int jumlahTankTersembunyi = jumlahTank;
            while (jumlahTankTersembunyi > 0)
            {
                int[] tebakanKoordinat = getKoordinatTebakan(panjangArena);
                char updateTampilanArena = verifikasiTebakan(tebakanKoordinat, playArena, tank, rumput, hit, miss);
                if (updateTampilanArena == hit)
                {
                    jumlahTankTersembunyi--;
                }
                playArena = updateArena(playArena, tebakanKoordinat, updateTampilanArena);
                print(playArena, rumput, tank);
            }
            Console.WriteLine("Game Over!");
        }
        private static char[,] buatRuang(int panjangArena, char rumput, char tank, int jumlahTank)
        {
            char[,] ruangan = new char[panjangArena, panjangArena];

            for (int baris = 0; baris < panjangArena; baris++)
            {
                for (int kolom = 0; kolom < panjangArena; kolom++)
                {
                    ruangan[baris, kolom] = rumput;
                }
            }
            return letakkanTank(ruangan, jumlahTank, rumput, tank);
        }
        private static char[,] letakkanTank(char[,] ruangan, int jumlahTank, char rumput, char tank)
        {
            int letakTank = 0;
            int panjangArena = 5;

            while (letakTank < jumlahTank)
            {
                int[] lokasiTank = koordinatTank(panjangArena);
                char posisi = ruangan[lokasiTank[0], lokasiTank[1]];

                if (posisi==rumput)
                {
                    ruangan[lokasiTank[0], lokasiTank[1]] = tank;
                    letakTank++;
                }
            }
            return ruangan;
        }
        private static int[] koordinatTank(int panjangArena)
        {
            Random rnd = new Random();
            int[] koordinat = new int[2];
            for (int i = 0; i < koordinat.Length; i++)
            {
                koordinat[i] = rnd.Next(panjangArena); 
            }
            return koordinat;
        }
        private static void print(char[,] playArena, char rumput, char tank)
        {
            Console.Write("  ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + " ");
            }
            Console.WriteLine();
            for (int baris = 0; baris < 5; baris++)
            {
                Console.Write(baris + 1 + " ");
                for (int kolom = 0; kolom < 5; kolom++)
                {
                    char posisi = playArena[baris, kolom];
                    if (posisi == tank)
                    {
                        Console.Write(rumput + " ");
                    } 
                    else
                    {
                        Console.Write(posisi + " ");
                    }
                }
                Console.WriteLine();
            }
        }
        static int[] getKoordinatTebakan(int panjangArena)
        {
            int baris;
            int kolom;

            do
            {
                Console.Write("Pilih Baris: ");
                baris = Convert.ToInt32(Console.ReadLine());
            } while (baris < 0 || baris > panjangArena + 1);

            do
            {
                Console.Write("Pilih Kolom: ");
                kolom = Convert.ToInt32(Console.ReadLine());
            } while (kolom < 0 || kolom > panjangArena + 1);
            return new[]{baris - 1, kolom - 1};
        }
        static char verifikasiTebakan(int[] tebakan, char[,] playArena, char tank, char rumput, char hit, char miss)
        {
            string pesan;
            int baris = tebakan[0];
            int kolom = tebakan[1];
            char target = playArena[baris, kolom];

            if (target == tank)
            {
                pesan = "Hit!";
                target = hit;
            } 
            else if (target == rumput)
            {
                pesan = "Miss!";
                target = miss;
            }
            else
            {
                pesan = "Clear!";
            }
            Console.WriteLine(pesan);
            Console.WriteLine("----");
            return target;
        }
        static char[,] updateArena(char[,] Arena, int[] tebakanKoordinat, char updateTampilanArena)
        {
            int baris = tebakanKoordinat[0];
            int kolom = tebakanKoordinat[1];
            Arena[baris, kolom] = updateTampilanArena;
            return Arena;   
        }
    }
}