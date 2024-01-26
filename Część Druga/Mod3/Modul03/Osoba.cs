using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kadry
{
    class Adres
    {
        private string miejscowosc;
        private string kod;
        private string nazwaUlicy;
        private int numerDomu;
        private int? numerMieszkania;

        public Adres(int numerDomu, int? numerMieszkania, string nazwaUlicy, string kod, string miejscowosc)
        {
            this.numerDomu = numerDomu;
            this.numerMieszkania = numerMieszkania;
            this.nazwaUlicy = nazwaUlicy;
            this.kod = kod;
            this.miejscowosc = miejscowosc;
        }
        public Adres(int numerDomu, int? numerMieszkania, string nazwaUlicy)
            :this(numerDomu,numerMieszkania,nazwaUlicy,"02-222", "Warszawa")
        {            
        }
        public Adres(int numerDomu, int? numerMieszkania)
            : this(numerDomu, numerMieszkania, "Aleje Jerozolimskie")
        {
        }
        public Adres(int numerDomu)
            :this(numerDomu, null)
        {            
        }

        public Adres(Adres adres)
            : this(adres.numerDomu, adres.numerMieszkania, adres.nazwaUlicy, adres.kod,adres.miejscowosc)
        {
        }

          
    }
       class Osoba
    {
        private string nazwisko;
        private string imie;
        private int numerEwidencyjny;
        private Adres adresZamieszkania;
        private int rokUrodzenia;

       public Osoba(int numerEwidencyjny, int rokUrodzenia, string imie, string nazwisko, Adres adres)
        {
            this.rokUrodzenia = rokUrodzenia;
            this.numerEwidencyjny = numerEwidencyjny;
            this.imie = imie;
            this.nazwisko = nazwisko;
            adresZamieszkania = adres;
        }

        public Osoba(int numerEwidencyjny, int rokUrodzenia, string imie, string nazwisko, int numerDomu, int? numerMieszkania, string nazwaUlicy, string kod, string miejscowosc)
            : this(numerEwidencyjny, rokUrodzenia, imie, nazwisko, new Adres(numerDomu,numerMieszkania,nazwaUlicy,kod,miejscowosc))
        {         
        }

        

        public Osoba(int numerEwidencyjny, int rokUrodzenia, string imie, int numerDomu)
            : this(numerEwidencyjny, rokUrodzenia, imie, "Kowalski", numerDomu, null, "Aleje Jerrozolimskie", "02-222", "Warszawa")
        {
        }
        public Osoba(Osoba osoba)
        {
            numerEwidencyjny = osoba.numerEwidencyjny;
            imie = osoba.imie;
            nazwisko = osoba.nazwisko;
            adresZamieszkania = new Adres(osoba.adresZamieszkania);            
        }         
    }
}
