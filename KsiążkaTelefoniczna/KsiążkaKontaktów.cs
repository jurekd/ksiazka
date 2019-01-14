using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace KsiążkaTelefoniczna
{
    public class KsiążkaKontaktów
    {
        public Dictionary<string, Kontakt> ksiazka= new Dictionary<string,Kontakt>();


        //Dictionary<string, string> slownik = new Dictionary<string, string>();
        public void DodajKontakt(Kontakt k)
        {
            ksiazka[k.Imię + k.Nazwisko] = k;
            //slownik["run"] = "biegać";
        }
        public string SzukajOsoby(string imię, string nazwisko)
        {
            if (ksiazka.ContainsKey(imię + nazwisko))
                return ksiazka[imię + nazwisko].Telefon;
            else
                return "nie znaleziono";
        }
        public void ZapiszJSON(string nazwaPliku)
        {
            string json = new JavaScriptSerializer().Serialize(this);
            File.WriteAllText(nazwaPliku,json);
        }

        public static KsiążkaKontaktów OdczytJSON(string nazwaPliku)
        {
            string json = File.ReadAllText(nazwaPliku);
            KsiążkaKontaktów ksiazka= new JavaScriptSerializer().Deserialize(json,typeof(KsiążkaKontaktów)) as KsiążkaKontaktów;
            
            return ksiazka;
        }
    }
}
