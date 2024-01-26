﻿using System;

namespace TestListy
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Listy.Lista oryginal = new Listy.Lista();
            oryginal.DodajDoGlowy("Ania");
            oryginal.DodajDoGlowy("Agnieszka");
            oryginal.DodajDoGlowy("Wiktoria");
            oryginal.DodajDoGlowy("Kasia");

            Listy.Lista kopiaR = oryginal.KlonujRekurencyjnie();
            Listy.Lista kopiaI = oryginal.KlonujIteracyjnie();

            Console.WriteLine("Wypisujemy przed modyfikacjami: ");
            oryginal.WypiszWszystko();
            Console.WriteLine("\n***Oryginał: ");
            oryginal.WypiszWszystko();
            Console.WriteLine("\n***Kopia R: ");
            kopiaR.WypiszWszystko();
            Console.WriteLine("\n***Kopia I: ");
            kopiaI.WypiszWszystko();

            Console.WriteLine("\nModyfikujemy:");
            Console.ReadKey();

            kopiaR.DodajDoGlowy("Zosia");
            kopiaR.DodajDoGlowy("Zola");
            kopiaI.UsunZGlowy();
            kopiaI.UsunZGlowy();

            Console.WriteLine("\n***Oryginał: ");
            oryginal.WypiszWszystko();
            Console.WriteLine("\n***Kopia R: ");
            kopiaR.WypiszWszystko();
            Console.WriteLine("\n***Kopia I: ");
            kopiaI.WypiszWszystko();

            Console.ReadKey();

        }
    }
}