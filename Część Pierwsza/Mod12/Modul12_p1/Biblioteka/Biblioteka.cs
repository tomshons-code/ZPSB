using System;


namespace Biblioteka
{
    public class Biblioteka
    {
        
        public struct Data
        {
            public int Rok;
            public byte Miesiac;
            public byte Dzien;
            
            public static void WprowadzDate(out Data d)
        {
            Console.Write("Podaj rok: ");
            d.Rok = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("Podaj miesiac: ");
                d.Miesiac = Convert.ToByte(Console.ReadLine());
            }
            while (d.Miesiac < 1 || d.Miesiac > 12);
    
            bool flaga = true;
            do
            {
                Console.Write("Podaj dzien: ");
                d.Dzien = Convert.ToByte(Console.ReadLine());
                if(d.Dzien>=1 && d.Dzien<=31)
                {
                    switch (d.Miesiac)
                    {
                        case 01:
                            if (d.Dzien <= 31)
                                flaga = false;
                            break;
                        case 02:
                            if (d.Dzien < 29)
                                flaga = false;
                            break;
                        case 03:
                            if (d.Dzien <= 31)
                                flaga = false;
                            break;
                        case 04:
                            if (d.Dzien <=30)
                                flaga = false;
                            break;
                        case 05:
                            if (d.Dzien <= 31)
                                flaga = false;
                            break;
                        case 06:
                            if (d.Dzien <= 30)
                                flaga = false;
                            break;
                        case 07:
                            if (d.Dzien <= 31)
                                flaga = false;
                            break;
                        case 08:
                            if (d.Dzien <=31)
                                flaga = false;
                            break;
                        case 09:
                            if (d.Dzien <= 30)
                                flaga = false;
                            break;
                        case 10:
                            if (d.Dzien < 31)
                                flaga = false;
                            break;
                        case 11:
                            if(d.Dzien<= 30)
                                flaga = false;
                            break;
                        case 12:
                            if (d.Dzien <= 31)
                                flaga = false;
                            break;
                        default:
                            flaga = false;
                            break;
                    }
                }
            }
            while (flaga);
        }
            public static void WypiszDate(Data d)
            {
                Console.Write("{0}{1}{2}", d.Dzien, d.Miesiac, d.Rok);
            }
        }
        
        
        public struct Osoba
        {
            public string Imie;
            public string Nazwisko;
            public Data DataUrodzenia;
            
            public static void WprowadzOsobe(out Osoba os)
            {
                Console.Write("Podaj imie: ");
                os.Imie = Console.ReadLine();
                Console.Write("Podaj nazwisko: ");
                os.Nazwisko = Console.ReadLine();
                Data.WprowadzDate(out os.DataUrodzenia);
            }

            public static void WypiszOsobe(Osoba os)
            {
                Console.Write("Pan(i) {0} {1}, urodzony(a): ", os.Imie, os.Nazwisko);
                Data.WypiszDate(os.DataUrodzenia);
            }
        }
        
    }
}