using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiążkaTelefoniczna
{
    public struct Kontakt
    {
        public string Imię;
        public string Nazwisko;
        public string Telefon;

        public Kontakt(string imię, string nazwisko, string telefon)
        {
            Imię = imię;
            Nazwisko = nazwisko;
            Telefon = telefon;
        }
    }
}
