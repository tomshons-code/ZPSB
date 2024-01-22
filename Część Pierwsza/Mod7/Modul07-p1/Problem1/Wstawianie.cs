using System;

namespace Modul07_p1
{
    internal class Wstawianie
    {
        public static void Main(string[] args)
        {
            double[] tablica = new double[15];
            Random generator = new Random();

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = generator.NextDouble();
            }
            
            Console.WriteLine("Wylosowano następujące wartości: ");
            foreach (double i in tablica)
            {
                Console.WriteLine("{0:f3}; ", i);   
            }

            double x;
            int j;
            for (int i = 0; i < tablica.Length; i++)
            {
                x = tablica[i];
                for (j = i-1; j >= 0 && x < tablica[j] ; j--)
                {
                    tablica[j + 1] = tablica[j];
                }
                //tablica[j+1] = //Błąd w treści zadania brakuje informacji o wartości do przypisania
            }

            int l, p, m; //Ponowna deklaracja zmiennej j w teści zadania powoduje konflikt programu
            //double x;
        }
    }
}