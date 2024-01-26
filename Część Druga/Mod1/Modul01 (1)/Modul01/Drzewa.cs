using System;
using System.Collections.Generic;
using System.Text;

using Biblioteka;

namespace Drzewa
{
    public class Drzewo
    {
        public class Wezel
        {
            public Osoba Dane;
            public Wezel Lewy, Prawy;
        }
        public Wezel Korzen;

        public static bool CzyPusty(Drzewo drzewo)
        {
            return drzewo.Korzen == null;
        }

        public static void DodajElement(Drzewo drzewo, Osoba osoba)
        {
            if(drzewo.Korzen == null)
            {
                drzewo.Korzen = new Wezel();
                drzewo.Korzen.Dane = osoba;
                return ;
            }
            Wezel p = drzewo.Korzen, poprzedni;
            do{
                poprzedni = p;
                if(Osoba.CompareTo(osoba,p.Dane )<0)
                    p = p.Lewy;
                else
                    p = p.Prawy;
            }
            while(p != null);
            if (Osoba.CompareTo(osoba, poprzedni.Dane) < 0)
            {
                poprzedni.Lewy = new Wezel();
                poprzedni.Lewy.Dane = osoba;
            }
            else
            {
                poprzedni.Prawy = new Wezel();
                poprzedni.Prawy.Dane = osoba;
            }
        }

        public static Osoba UsunElement(Drzewo drzewo, string nazwisko, string imie)
        {
            Osoba osoba = new Osoba();
            osoba.Imie = imie;
            osoba.Nazwisko = nazwisko;

            Wezel p = drzewo.Korzen, rodzic = drzewo.Korzen;
            #region Znajdowanie wêz³a do usuniêcia
            while (p != null)
            {
                if (Osoba.CompareTo(osoba, p.Dane) == 0)
                    break;
                else
                {
                    rodzic = p;
                    if (Osoba.CompareTo(osoba, p.Dane)<0)
                        p = p.Lewy;
                    else
                        p = p.Prawy;
                }
            }
            #endregion
           
            if (p == null)
                return null;
            osoba = p.Dane;
            if (p == drzewo.Korzen)
                UsunWezel(ref drzewo.Korzen);
            else
                if (p == rodzic.Prawy)
                    UsunWezel(ref rodzic.Prawy);
                else
                    UsunWezel(ref rodzic.Lewy);
            return osoba;
        }

        public static void UsunWezel(ref Wezel wezel)
        {
            if (wezel.Prawy == null)   //brak prawego dziecka
                wezel = wezel.Lewy;
            else
                if (wezel.Lewy == null)    //brak lewego dziecka
                    wezel = wezel.Prawy;
                else
                {               //usuwany wêze³ ma oboje dzieci
                    Wezel tmp = wezel.Lewy;
                    Wezel poprzedni = wezel;
                    //Zanjdowanie prawego skrajnego wêz³a w lewym poddrzewie
                    while (tmp.Prawy != null)
                    {
                        poprzedni = tmp;
                        tmp = tmp.Prawy;
                    }
                    wezel.Dane  = tmp.Dane;
                    if (poprzedni == wezel) 
                        poprzedni.Lewy = tmp.Lewy;
                    else
                        poprzedni.Prawy = tmp.Lewy;
                }
        }

        public static void WypiszWszystko(Drzewo drzewo)
        {
            WypiszWezel(drzewo.Korzen);
        }

        public static void WypiszWezel(Wezel wezel)
        {
            if (wezel != null)
            {
                WypiszWezel(wezel.Lewy);
                Osoba.WypiszOsobe(wezel.Dane);
                Console.WriteLine();
                WypiszWezel(wezel.Prawy);
            }
        }

        public static Osoba ZnajdzElement(Drzewo drzewo,string nazwisko,string imie)
        {
            Osoba osoba = new Osoba();
            osoba.Imie = imie;
            osoba.Nazwisko = nazwisko;
            Wezel p = drzewo.Korzen;
            while (p != null)
            {
                if (Osoba.CompareTo(osoba,p.Dane)==0)
                    return p.Dane;
                else
                    if (Osoba.CompareTo(osoba, p.Dane)<0)
                        p = p.Lewy;
                    else
                        p = p.Prawy;
            }
            return null;
        }
    }

}
