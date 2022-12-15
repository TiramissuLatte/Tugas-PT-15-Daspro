using System;

namespace DasproUTS
{
    class program
    {
        //soal pertama membuat nametag
        static void Main(string[] args)
        {
            string namaPanjang, nim, konsentrasi;
            Console.WriteLine("NAMA : ");
            namaPanjang = Console.ReadLine().ToUpper();
            Console.WriteLine("NIM : ");
            nim = Console.ReadLine();
            Console.WriteLine("Konsentrasi yang dipilih : ");
            konsentrasi = Console.ReadLine().ToUpper();

            Console.WriteLine("|****************************************|");
            Console.WriteLine("{0,-8} {1,27}", "|NAMA        :", namaPanjang+"|");
            Console.WriteLine("|----------------------------------------|");
            Console.WriteLine("{0,-15} {1, 26}", "|NIM         :", nim+"|");
            Console.WriteLine("|----------------------------------------|");
            Console.WriteLine("{0,-15} {1,26}", "|KONSENTRASI :", konsentrasi+"|");
            Console.WriteLine("|****************************************|");
        }
    }
}