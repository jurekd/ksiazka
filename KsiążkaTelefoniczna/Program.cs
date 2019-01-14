using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiążkaTelefoniczna
{
    class Program
    {
        static void Main(string[] args)
        {
            Kontakt k1 = new Kontakt("Jan", "Nowak", "100");
            Kontakt k2 = new Kontakt("Anna", "Maj", "200");
            KsiążkaKontaktów książka = new KsiążkaKontaktów();
            książka.DodajKontakt(k1);
            książka.DodajKontakt(k2);
            Console.WriteLine(książka.SzukajOsoby("Jan", "Nowak"));
            Console.WriteLine(książka.SzukajOsoby("Adam", "Nowak"));
            książka.ZapiszJSON("ksiazka.json");
            KsiążkaKontaktów książka2 = KsiążkaKontaktów.OdczytJSON("ksiazka.json");

            Console.ReadKey();
        }
    }
}
