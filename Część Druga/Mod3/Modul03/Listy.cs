using System;
using System.Collections.Generic;
using System.Text;

namespace Listy
{
    public class Lista
    {
        class Wezel
        {
            public string Dane;
            public Wezel Nastepny;

        }

        private Wezel glowa=null;

        public bool CzyPusta()
        {
            return glowa == null;
        }

        public void DodajDoGlowy(string s)
        {
            Wezel tmp = new Wezel();
            tmp.Dane = s;
            tmp.Nastepny = glowa;
            glowa = tmp;
        }

        public string UsunZGlowy()
        {
            if (glowa == null)           //lista pusta
                throw new InvalidOperationException("Lista jest pusta");
            string x = glowa.Dane;
            glowa = glowa.Nastepny;
            return x; 
        }       

        public void WypiszWszystko()
        {
            for (Wezel tmp = glowa; tmp != null; tmp = tmp.Nastepny)
            {
                Console.WriteLine(tmp.Dane);
            }
        }       

        public int PobierzLiczbeElementow()
        {
            int i;
            Wezel tmp;
            for (i = 0, tmp = glowa; tmp != null; i++, tmp = tmp.Nastepny) ;
            return i;
        }

    }
}
