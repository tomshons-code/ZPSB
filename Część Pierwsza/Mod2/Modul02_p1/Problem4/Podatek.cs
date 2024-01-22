using System;

namespace Podatek
{
    internal class Podatek
    {
        public static void Main(string[] args)
        {
            //Deklaracja stałej sumbolicznej oraz zmiennej
            const decimal Vat = 0.22M;
            decimal netto;

            //Pobieranie ceny netto
            Console.Write("Podaj cenę netto: ");
            netto = Convert.ToDecimal(Console.ReadLine());

            //Deklarazja zmiennych
            decimal podatek = Vat * netto;
            decimal brutto = netto + podatek;

            //Wypisanie wartości
            Console.WriteLine("Cena wynosi {0:C}, w tym kwota podatku: {1:C}", brutto, podatek);

            //Zakończenie programu
            Console.ReadKey(); 
        }
    }
}