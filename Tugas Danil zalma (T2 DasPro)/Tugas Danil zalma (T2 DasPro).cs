﻿using System;

namespace Newfolder
{
    class Program
    {
        //main Method
        static void Main(string[] args)
        {
            //Deklarasi Variabel
            int kodeA = 4;
            int kodeB = 8;
            int kodeC = 16;
            int jumlahKode = 3;
            String tebakanA;
            String tebakanB;
            String tebakanC;

            int hasilTambah;
            int hasilKali;

            //Inisialisasi Variabel
            kodeA = 1;
            kodeB = 2;
            kodeC = 3;

            jumlahKode = 3;

            //Operasi Aritmatika
            hasilTambah = kodeA+kodeB+kodeC;
            hasilKali = kodeA*kodeB*kodeC;

            //Intro
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server...");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui....");
            Console.WriteLine("Password terdiri dari "+jumlahKode+" angka");
            Console.WriteLine("jika ditambahkan hasilnya "+hasilTambah);
            Console.WriteLine("jika dikalikan hasilnya "+hasilKali);

            //Input User
            Console.Write("Masukkan kode 1 : ");
            tebakanA = Console.ReadLine();
            Console.Write("Masukkan kode 2 : ");
            tebakanB = Console.ReadLine();
            Console.Write("Masukkan Kode 3 : ");
            tebakanC = Console.ReadLine();

            Console.WriteLine("Tebakan Anda : "+ tebakanA +" "+ tebakanB +" "+ tebakanC +" ?");

            //If Statement
            if(tebakanA == kodeA.ToString() && tebakanB == kodeB.ToString() && tebakanC == kodeC.ToString())
            {
                Console.WriteLine("Tebakan anda benar!");
            }else{
                Console.WriteLine("Tebakan anda salah!");
            }
        }
    }
}    