using System;

namespace Modul09_p1
{
    internal class Kasjer
    {
        static decimal cenaBrutto, kwotaWplacona, cenaNetto;
        const decimal StawkaPodatku = 0.22m;
        
        static void Pobierz()
        {
            do
            {
                Console.Write("\nPodaj cenę (netto) towaru zakupionego przez klienta: ");
                cenaNetto = Convert.ToDecimal(Console.ReadLine());
            }
            while (cenaNetto <= 0);
        
            cenaNetto = Decimal.Round(cenaNetto, 2);
            cenaBrutto = Decimal.Round(cenaNetto * (1 + StawkaPodatku), 2);
            Console.WriteLine("Cena brutto wynosi: {0:C}", cenaBrutto);
        
            do
            {
                Console.Write("Podaj kwotę wpłaconą przez klienta: ");
                kwotaWplacona = Convert.ToDecimal(Console.ReadLine());
            }
            while (kwotaWplacona <= 0);
        
            kwotaWplacona = Decimal.Round(kwotaWplacona, 2);
        
            if (cenaBrutto > kwotaWplacona)
            {
                throw new Exception("Cena towaru nie może być większa od kwoty wpłaconej przez klienta!!!");
            }
        } 
        
        static void Wypisz()
        {
            Console.WriteLine("\n\n\n**********************");
            Console.WriteLine("\nKwota wpłacona przez klienta: {0:C}", kwotaWplacona);
            Console.WriteLine("\nCena netto: {0:C}", cenaNetto);
            Console.WriteLine("\nCena brutto: {0:C}", cenaBrutto);
            Console.WriteLine("\nWartość podatku: {0:C}", cenaBrutto - cenaNetto);
        }
        
        static void Reszta()
        {
            decimal reszta = kwotaWplacona - cenaBrutto;
            int ilosc = 0;
            Console.WriteLine("\nWartość reszty należnej klientowi: {0:C}", reszta);

            while (100 <= reszta)
            {
                ilosc++;
                reszta -= 100;
            }
            if (ilosc != 0)
            {
                Console.WriteLine("\tLiczba banknotów {0:C}: {1}", 100, ilosc);
                ilosc = 0;
            }

            while (50 <= reszta)
            {
                ilosc++;
                reszta -= 50;
            }
            if (ilosc != 0)
            {
                Console.WriteLine("\tLiczba banknotów {0:C}: {1}", 50, ilosc);
                ilosc = 0;
            }
            
            while (20 <= reszta)
            {
                ilosc++;
                reszta -= 20;
            }
            if (ilosc != 0)
            {
                Console.WriteLine("\tLiczba banknotów {0:C}: {1}", 20, ilosc);
                ilosc = 0;
            }
            
            while (10 <= reszta)
            {
                ilosc++;
                reszta -= 10;
            }
            if (ilosc != 0)
            {
                Console.WriteLine("\tLiczba banknotów {0:C}: {1}", 10, ilosc);
                ilosc = 0;
            }
        }


        
        
        
        public static void Main(string[] args)
        {
            char c = 't';
            do
            {
                try
                {
                    Pobierz();
                    Wypisz();
                    Reszta();
                    Console.WriteLine("\nCzy jest jeszcze jakiś klient?");
                    c = Console.ReadKey().KeyChar;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (c == 't' || c == 'T');
        }
    }
    
}