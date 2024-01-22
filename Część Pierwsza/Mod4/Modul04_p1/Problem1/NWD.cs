using System;

namespace Modul04_p1
{
  internal class NWD
  {
    public static void Main(string[] args)
    {
      // Deklaracja zmiennych.
      ulong m, n, roznica;

      //Pobranie wartości zmiennych.
      Console.Write("Podaj wartość m: ");
      m = Convert.ToUInt64(Console.ReadLine());
      Console.Write("Podaj wartość n: ");
      n = Convert.ToUInt64(Console.ReadLine());

      //Wykonuj póki wartość zmiennej różnica będzie różna od zera
      do
      {
        roznica = m > n ? m - n : n - m;
        if (n > m)
          n = roznica;
        else
          m = roznica;
      } while (roznica != 0);
      
      //Wypisanie wartośc
      Console.WriteLine("Największy wspólny dzielnik podanych liczb to {0}", n);
      
      //Zakończenie programu 
      Console.ReadKey();
    }
  }
}