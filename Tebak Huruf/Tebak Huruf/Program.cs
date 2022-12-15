using System;
using System.Collections.Generic;

namespace TebakHuruf
{
    class Program
    {
        static string kataRahasia = "spongebob";
        static int kesempatan = 5;
        static List<string> tebakanPemain = new List<string>{};
        static void Main(string[] args)
        {
            Intro();
            PlayGame();
            EndGame();
        }

        static void Intro()
        {
            Console.WriteLine("Selamat Datang, hari ini kita akan bermain tebak kata");
            Console.WriteLine($"Kamu mempunyai {kesempatan} kesempatan untuk menebak kata misteri hari ini");
            Console.WriteLine("petunjuknya adalah kata ini merupakan film animasi.");
            Console.WriteLine($"kata ini terdiri dari {kataRahasia.Length} karakter.");
            Console.WriteLine("film apakah yang dimaksud?");
            Console.ReadKey();
        }

        static string cekHuruf(string Kata, List<string> List)
        {
            string letakKata = "";
            for (int i = 0; i < Kata.Length; i++)
            {
                string sisaKata = Convert.ToString(Kata[i]);
                if(List.Contains(sisaKata))
                {
                    letakKata += sisaKata;
                }
                else
                {
                    letakKata += "_";
                }
            }
            return letakKata;
        }

        static bool cekJawaban(string Kata, List<string> List)
        {
            bool letakKata = false;
            for (int i = 0; i < Kata.Length; i++)
            {
                string sisaKata = Convert.ToString(Kata[i]);
                if (List.Contains(sisaKata))
                {
                    letakKata = true;
                }
                else
                {
                    return letakKata = false;
                }
            }
            return letakKata;
        }

        static void PlayGame()
        {
            while (kesempatan>0)
            {
                Console.Write("Apa karakter tebakanmu? (a-z): ");
                string input = Console.ReadLine().ToLower();
                tebakanPemain.Add(input);

                if(cekJawaban(kataRahasia, tebakanPemain))
                {
                    Console.WriteLine("Selamat, Anda berhasil menebak Kata Rahasia!");
                    Console.WriteLine($"Kata Rahasianya adalah: {kataRahasia}.");
                    break;
                }
                else if(kataRahasia.Contains(input))
                {    
                    Console.WriteLine($"Huruf {input} terdapat didalam kata rahasia.");
                    Console.WriteLine(cekHuruf(kataRahasia, tebakanPemain));
                    Console.WriteLine("silahkan melanjutkan untuk menebak kata!.");
                }
                else
                {
                    Console.WriteLine("Maaf, kata yang anda masukkan tidak ada dalam Kata Rahasia.");
                    kesempatan--;
                    Console.WriteLine($"Kesempatan anda untuk menebak tersisa {kesempatan}.");
                }   
            }
        }

        static void EndGame()
        {
            Console.WriteLine("Terimakasih sudah bermain!");
            if(kesempatan==0)
                {
                    Console.WriteLine("Mohon maaf kesempatan anda habis.");
                    Console.WriteLine($"kata misteri yang dimaksud adalah {kataRahasia}.");
                    Console.WriteLine("Terima kasih sudah bermain.");
                }
                Console.ReadKey();
        }
    }
}