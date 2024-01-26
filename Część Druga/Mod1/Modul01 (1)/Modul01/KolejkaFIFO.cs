using System;
using System.Collections.Generic;
using System.Text;


namespace KolejkaFIFO
{
    public class Kolejka
    {
        public string[] Elementy;
        public int Pierwszy;
        public int Ostatni;

        public static void Utworz(out Kolejka kolejka, int liczbaElementow)
        {
            kolejka.Pierwszy = kolejka.Ostatni = -1;
            kolejka.Elementy = new string[liczbaElementow];
        }

        public static bool CZyPelna(Kolejka kolejka)
        {
            return ((kolejka.Pierwszy == 0 && kolejka.Ostatni == kolejka.Elementy.Length - 1) || kolejka.Pierwszy == kolejka.Ostatni + 1);               
        }

        public static void DodajDoKolejki(ref Kolejka kolejka,string element)
        {
            if (Kolejka.CZyPelna(kolejka))
                throw new InvalidOperationException("Kolejka jest pe³na");
            if (kolejka.Ostatni == kolejka.Elementy.Length - 1 || kolejka.Ostatni == -1)
            {
                kolejka.Elementy[0] = element;
                kolejka.Ostatni = 0;
                if (kolejka.Pierwszy == -1)
                    kolejka.Pierwszy = 0;
            }
            else
                kolejka.Elementy[++kolejka.Ostatni] = element;
        }

        public static bool CzyPusta(Kolejka kolejka)
        {
            return kolejka.Pierwszy == -1;
        }

        public static string UsunZKolejki(ref Kolejka kolejka)
        {
            if (Kolejka.CzyPusta(kolejka))
                throw new InvalidOperationException("Kolejka jest pusta");
            string tmp;
            tmp = kolejka.Elementy[kolejka.Pierwszy];
            if (kolejka.Pierwszy == kolejka.Ostatni)
                kolejka.Ostatni = kolejka.Pierwszy = -1;
            else
                if (kolejka.Pierwszy == kolejka.Elementy.Length - 1)
                    kolejka.Pierwszy = 0;
                else
                    kolejka.Pierwszy++;
            return tmp;
        }

        public static void Wyczysc(ref Kolejka kolejka)
        {
            Kolejka.Utworz(out kolejka, kolejka.Elementy.Length);
        }

        public static string SprawdzElement(Kolejka kolejka)
        {
            if (Kolejka.CzyPusta(kolejka))
                throw new InvalidOperationException("Kolejka jest pusta");
            return kolejka.Elementy[kolejka.Pierwszy];
        }

        public static int PobierzLiczbeElementow(Kolejka kolejka)
        {
            if(kolejka.Pierwszy == -1)
                return 0;
            if (kolejka.Pierwszy <= kolejka.Ostatni)
                return kolejka.Ostatni - kolejka.Pierwszy + 1;
            return kolejka.Elementy.Length - kolejka.Pierwszy + kolejka.Ostatni + 1;
        }
    }
}
