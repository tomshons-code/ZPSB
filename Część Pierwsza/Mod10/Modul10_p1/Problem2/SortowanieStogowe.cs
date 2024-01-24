using System;

namespace Problem2
{
    internal class SortowanieStogowe
    {
        static void Przesiewaj(double[] tab, uint l, uint p)
        {
            uint i = l, j = 2*i+1;
            double x = tab[i];
            while (j <= p)
            {
                if (j<p)
                {
                    if (tab[j] < tab[j+1])
                    {
                        j++;
                    }
                }

                if (tab[j] < x)
                {
                    break;
                }
                tab[i] = tab[j];
                i = j;
                j = 2*i+1;
            }
            if (i != l)
                tab[i] = x;
        }
        
        static void Przesiewaj(string[] tab, uint l, uint p)
        {
            uint i = l , j = 2 * i + 1;
            string x = tab[i];
            while (j <= p)
            {
                if (j < p)
                    if (string.Compare(tab[j], tab[j + 1]) < 0)
                    {
                        j++;
                    }

                if (string.Compare(tab[j], x) < 0)
                {
                    break;
                }
                tab[i] = tab[j];
                i = j;
                j = 2 * i + 1;
            }
            if (i != l)
                tab[i] = x;
        }
        
        static void Sortuj(double[] tab)
        {
            uint l = (uint)tab.Length / 2, p = (uint)tab.Length - 1;
            double x;
            while (l > 0)
            {
                l--;
                Przesiewaj(tab, l, p);
            }
            while (p > 0)
            {
                x = tab[0];
                tab[0] = tab[p];
                tab[p] = x;
                p--;
                Przesiewaj(tab, 0, p);
            }
        }

        static void Sortuj(string[] tab)
        {
            uint l = (uint)tab.Length / 2, p = (uint)tab.Length - 1;
            string x;
            while (l > 0)
            {
                l--;
                Przesiewaj(tab, l, p);
            }
            while (p > 0)
            {
                x = tab[0];
                tab[0] = tab[p];
                tab[p] = x;
                p--;
                Przesiewaj(tab, 0, p);
            }
        }


        
        
        public static void Main(string[] args)
        {
                double[] tab = { 2.3, 3, 45, 12.3, 4.3, 7.2 };
                Console.WriteLine("Tablica liczb rzeczywistych przed sortowaniem");
                foreach (double d in tab)
                    Console.Write("{0}; ", d);
                
                Sortuj(tab);
                Console.WriteLine("\nTablica liczb rzeczywistych po sortowaniu");
                foreach (double d in tab)
                    Console.Write("{0}; ", d);
                
                Console.WriteLine("\n\n**************\n");
                string[] napisy = { "szafa", "Szwecja", "szalik", "siano", "stog", "szampan", "Slowacja" };
                Console.WriteLine("Tabela wyrazów przed sortowaniem");
                foreach (string s in napisy)
                    Console.Write("{0}; ", s);

                Sortuj(napisy);
                Console.WriteLine("\nTabela wyrazów po sortowaniu");
                foreach (string s in napisy)
                    Console.Write("{0}; ", s);

                Console.ReadKey();
                
        }
    }
}