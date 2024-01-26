using System;
using System.Collections.Generic;
using System.Text;

using Osoba;

namespace Drzewa
{
    public class Drzewo
    {
        class Wezel
        {
            public Osoba.Osoba Dane;
            public Wezel Lewy=null, Prawy=null;

            public void WypiszWezel()
            {
                if (Lewy != null)
                    Lewy.WypiszWezel();
                Dane.WypiszOsobe();
                Console.WriteLine();
                if (Prawy != null)
                    Prawy.WypiszWezel();
            }
        
        }
        private Wezel korzen = null;

        public bool CzyPuste()
        {
            return korzen == null;
        }

        public void DodajElement(Osoba.Osoba osoba)
        {
            if(korzen == null)
            {
                korzen = new Wezel();
                korzen.Dane = osoba;
                return ;
            }
            Wezel p = korzen, poprzedni;
            do{
                poprzedni = p;
                if(osoba.CompareTo(p.Dane )<0)
                    p = p.Lewy;
                else
                    p = p.Prawy;
            }
            while(p != null);
            if (osoba.CompareTo(poprzedni.Dane) < 0)
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

        

        public void PrintAll()
        {
            if (korzen != null)
                korzen.WypiszWezel();
        }

        

 
    }

}
