using System;
using System.Collections.Generic;
using System.Text;


using KolejkaFIFO;

namespace TestKolejki
{
    class Program
    {
        static char Menu()
        {
            Console.Clear();
            Console.WriteLine("\n\t\tA - Dodaj napisdo kolejki");
            Console.WriteLine("\n\t\tB - Usu� napisz kolejki");
            Console.WriteLine("\n\t\tC - Podaj liczb� element�w w kolejce");
            Console.WriteLine("\n\t\tD - Wyczy�� kolejk�");
            Console.WriteLine("\n\t\tK - Koniec");
            return Console.ReadKey(true).KeyChar;

        }
        static void Main(string[] args)
        {
            Kolejka mojaKolejka= new Kolejka();
            Kolejka.Utworz(out mojaKolejka, 10);
            string tmp;
            char c;

            do
            {
                c = Menu();
                switch (c)
                {
                    case 'a':
                    case 'A':
                        Console.Write("Podaj napis kt�ry ma by� dodany do kolejki: ");
                        tmp = Console.ReadLine();
                        Kolejka.DodajDoKolejki(ref mojaKolejka, tmp);
                        break;
                    case 'b':
                    case 'B':
                        Console.WriteLine("Napis wyj�ty z kolejki: {0}", Kolejka.UsunZKolejki(ref mojaKolejka));
                        Console.ReadKey();
                        break;
                    case 'c':
                    case 'C':
                        Console.WriteLine("Liczba element�w w kolejce wynosi: {0}", 
                            Kolejka.PobierzLiczbeElementow(mojaKolejka));
                        Console.ReadKey();
                        break;
                    case 'd':
                    case 'D':
                        Kolejka.Wyczysc(ref mojaKolejka);
                        Console.WriteLine("Kolejka wyczyszczona!!!");
                        Console.ReadKey();
                        break;
                }
            }
            while (!(c == 'k' || c == 'K'));
        }
    }
}
