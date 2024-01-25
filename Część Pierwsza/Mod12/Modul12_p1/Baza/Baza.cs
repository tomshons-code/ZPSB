using System;

namespace Modul12_p1
{
    internal class Baza
    {
        
        public struct Kontakty
        {
            public Biblioteka.Biblioteka.Osoba[] Osoby;
            public uint LiczbaOsob;
            
            public static void WprowadzKontakt(ref Kontakty kontakty)
            {
                if (kontakty.LiczbaOsob >= kontakty.Osoby.Length)
                    throw new Exception("Baza jest pełna");
                Biblioteka.Biblioteka.Osoba.WprowadzOsobe(out kontakty.Osoby[kontakty.LiczbaOsob]);
                kontakty.LiczbaOsob++;
            }
            
            public static void WypiszKontakty(Kontakty kontakty)
            {
                for (int i = 0; i < kontakty.LiczbaOsob; i++)
                {
                    Console.Write("{0}. ", i + 1);
                    Biblioteka.Biblioteka.Osoba.WypiszOsobe(kontakty.Osoby[i]);
                    Console.WriteLine();
                    
                    if ((i + 1) % Console.WindowHeight == 0)
                    {
                        Console.ReadKey();
                    }
                }
                Console.ReadKey();
            }
            
            public static void UtworzKontakty(
                out Kontakty kontakty, uint liczbaKontaktow)
            {
                kontakty.Osoby = new Biblioteka.Biblioteka.Osoba[liczbaKontaktow];
                kontakty.LiczbaOsob = 0;
            }
        }
        
        static char Menu()
        {
            Console.Clear();
            Console.WriteLine("\n\tA - Dodaj kontakt");
            Console.WriteLine("\n\tB - Wypisz wszystkie kontakty");
            Console.WriteLine("\n\tK - Zakończ program");
            return Console.ReadKey().KeyChar;
        }

        
        public static void Main(string[] args)
        {
                Kontakty mojeKontakty;
                Kontakty.UtworzKontakty(out mojeKontakty, 5);
                char c;
                do
                {
                    c = Menu();
                    switch (c)
                    {
                        case 'a':
                        case 'A':
                            Kontakty.WprowadzKontakt(ref mojeKontakty);
                            break;
                        case 'b':
                        case 'B':
                            Kontakty.WypiszKontakty(mojeKontakty);
                            break;
                    }
                }
                while (!(c == 'k' || c == 'K'));
            }
        }
    }
