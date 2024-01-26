using System;
using KolejkaFIFO;

namespace Problem2
{
    class Program
    {
        static char Menu()
        {
            Console.Clear();
            Console.WriteLine("\n\t\tA - Dodaj napis do kolejki");
            Console.WriteLine("\n\t\tB - Usu? napis z kolejki");
            Console.WriteLine("\n\t\tC - Podaj liczb? element�w w kolejce");
            Console.WriteLine("\n\t\tD - Wyczy?? kolejk?");
            Console.WriteLine("\n\t\tK - Koniec");
            return Console.ReadKey(true).KeyChar;

        }
        static void Main(string[] args)
        {
            Kolejka mojaKolejka = new Kolejka();
            mojaKolejka.Utworz(10);

            string tmp;
            char c;
            do
            {
                c = Menu();
                switch (c)
                {
                    case 'a':
                    case 'A':
                        Console.Write("Podaj napis kt�ry ma by? dodany do kolejki: ");
                        tmp = Console.ReadLine();
                        mojaKolejka.DodajDoKolejki(tmp);
                        break;
                    case 'b':
                    case 'B':
                        Console.WriteLine("Napis wyj?ty z kolejki: {0}", mojaKolejka.UsunZKolejki());
                        Console.ReadKey();
                        break;
                    case 'c':
                    case 'C':
                        Console.WriteLine("Liczba element�w w kolejki wynosi: {0}", mojaKolejka.PobierzLiczbeElementow());
                        Console.ReadKey();
                        break;
                    case 'd':
                    case 'D':
                        mojaKolejka.Wyczysc();
                        Console.WriteLine("Kolejka wyczyszczona!!!");
                        Console.ReadKey();
                        break;
                }
            } while (!(c == 'k') || (c == 'K'));

        }
    }
}
