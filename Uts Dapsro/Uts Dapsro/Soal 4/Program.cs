using System;

namespace DasproUts
{
    class program
    {
        static void Main(string[] args)
        {
            int poinKemenangan = 0;
            int poinKala = 0;
            int poinSeri = 0;
            char userInput = ' ';
            Random rnd = new Random();

            while (userInput != 'e')
            {
                Console.Write("Masukkan pilihan anda (b/g/k/e)");
                userInput = Convert.ToChar(Console.ReadLine());

                if (userInput == 'e')
                {
                    Console.WriteLine("Selamat tinggal");
                    break;
                    }
                        int comp = rnd.Next(1, 4);
                        if (userInput == 'b')
                        { 
                            if (comp == 1)
                            {
                                Console.WriteLine("Komputer memilih batu");
                                Console.WriteLine("seri");
                                poinSeri++;
                            }
                            else if (comp == 2)
                            {
                                Console.WriteLine("komputer memilih gunting");
                                Console.WriteLine("Kamu Kemenangan");
                                poinKemenangan++;
                            }
                            else if (comp == 3)
                            {
                                Console.WriteLine("Kemputer telah memilih kertas");
                                Console.WriteLine("Kamu Kekalahan");
                                poinKala++;
                            }
                            Console.WriteLine("poin"+poinKemenangan);
                            Console.WriteLine("poin"+poinKala);
                            Console.WriteLine("poin"+poinSeri); 
                        }
                        else if (userInput == 'g')
                        {
                        if (comp == 1)
                        {
                                Console.WriteLine("komputer memilih batu");
                                Console.WriteLine("Kamu Kekalahan");
                                poinKala++;
                            }
                            else if (comp == 2)
                            {
                                Console.WriteLine("Komputer memilih gunting");
                                Console.WriteLine("hasil seri");
                                poinSeri++;
                            }
                            else if (comp == 3)
                            {
                                Console.WriteLine("Kemputer telah memilih kertas");
                                Console.WriteLine("Kamu Kemenangan");
                                poinKemenangan++;
                            }
                            Console.WriteLine("poin"+poinKemenangan);
                            Console.WriteLine("poin"+poinKala);
                            Console.WriteLine("poin"+poinSeri); 
                        }
                        else if (userInput == 'k')
                        {
                            if (comp ==1)
                            {
                                Console.WriteLine("komputer memilih batu");
                                Console.WriteLine("Kamu Kemenangan");
                                poinKemenangan++;
                            }
                            else if (comp == 2)
                            {
                                Console.WriteLine("Komputer memilih gunting");
                                Console.WriteLine("Kamu Kekalahan");
                                poinKala++;
                            }
                            else if (comp == 3)
                            {
                                Console.WriteLine("Kemputer telah memilih kertas");
                                Console.WriteLine("Hasil seri");
                                poinKala++;
                            
                    } 
                            Console.WriteLine("poin"+poinKemenangan);
                            Console.WriteLine("poin"+poinKala);
                            Console.WriteLine("poin"+poinSeri); 
                }
            }
        
        }
    }
}