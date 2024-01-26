using System;
using System.Collections.Generic;
using System.Text;

using Biblioteka;
using Drzewa;


namespace TestDrzewa
{
    class Program
    {
        static char Menu()
        {
            Console.Clear();
            Console.WriteLine("\n\t\tA - Dodaj osobê do drzewa");
            Console.WriteLine("\n\t\tB - Usuñ osobê z drzewa");
            Console.WriteLine("\n\t\tC - ZanjdŸ osobê w drzewie");
            Console.WriteLine("\n\t\tD - Wypisz osoby z drzewa");
            Console.WriteLine("\n\t\tK - Koniec");
            return Console.ReadKey(true).KeyChar;
        }

        static void Main(string[] args)
        {
            Drzewo mojeDrzewo = new Drzewo();
            Osoba tmp;
            string imie, nazwisko;
            char c;
            do
            {
                c = Menu();
                switch (c)
                {
                    case 'a':
                    case 'A':
                        Osoba.WprowadzOsobe(out tmp);
                        Drzewo.DodajElement(mojeDrzewo, tmp);
                        break;
                    case 'b':
                    case 'B':
                        Console.Write("Podaj nazwisko osoby do usuniêcia: ");
                        nazwisko = Console.ReadLine();
                        Console.Write("Podaj imie osoby do usuniêcia: ");
                        imie = Console.ReadLine();
                        tmp = Drzewo.UsunElement(mojeDrzewo, nazwisko, imie);
                        if (tmp == null)
                            Console.WriteLine("Nie ma takiej osoby");
                        else
                            Osoba.WypiszOsobe(tmp);
                        Console.ReadKey();
                        break;
                    case 'c':
                    case 'C':
                        Console.Write("Podaj nazwisko osoby do znalezienia: ");
                        nazwisko = Console.ReadLine();
                        Console.Write("Podaj imie osoby do znalezienia: ");
                        imie = Console.ReadLine();
                        tmp = Drzewo.ZnajdzElement(mojeDrzewo, nazwisko, imie);
                        if (tmp == null)
                            Console.WriteLine("Nie ma takiej osoby");
                        else
                            Osoba.WypiszOsobe(tmp);
                        Console.ReadKey();
                        break;
                    case 'd':
                    case 'D':
                        Drzewo.WypiszWszystko(mojeDrzewo);
                        Console.ReadKey();
                        break;
                }
            }
            while (!(c == 'k' || c == 'K'));
        }
    }
}
