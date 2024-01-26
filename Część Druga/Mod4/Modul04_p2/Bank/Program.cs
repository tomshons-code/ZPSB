using System;
using Bank;

namespace Modul04_p2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Konto k1 = KontoDlaKonsoli.UtworzKonto();
            k1.Wplac();
            k1.Wyplac();
            k1.WypiszInformacjeOKoncie();
            k1.ZmienPin2();

            KontoDlaKonsoli.WypiszDebet();
            KontoDlaKonsoli.WypiszOprocentowanie();
            KontoDlaKonsoli.ZmienHaslo();
            KontoDlaKonsoli.ZmienMaksymalnyDebet();
            KontoDlaKonsoli.ZmienOprocentowanie();

            Console.ReadKey();

        }
    }
}