using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fozde_termekek
{
    public class Termek
    {
        public string ID;
        public string Nev;
        public int Evjarat;
        public double Alcohol;
        public double LiterAr;
        public List<Kiszereles> Kiszerelesek;
        public KiszTermKapcs Test;

        public Termek(string iD, string nev, int evjarat, double alcohol, double literAr)
        {
            ID = iD;
            Nev = nev;
            Evjarat = evjarat;
            Alcohol = alcohol;
            LiterAr = literAr;
            this.Kiszerelesek = new List<Kiszereles>();
            this.Kiszerelesek = getKiszereles();
        }
        
        public Termek(string nev, int evjarat, double alcohol, double literar, double liter)
        {
            Nev = nev;
            Evjarat = evjarat;
            Alcohol = alcohol;
            LiterAr = literar;
            KiszTermKapcs insToKiszTermKapcs = new KiszTermKapcs(Profile_page.Profil_page.Kiszerelesek[Profile_page.Profil_page.Kiszerelesek.FindIndex(x=>x.Liter==liter)].ID, Profile_page.Profil_page.Termekek[Profile_page.Profil_page.Termekek.Count-1].ID+1);
            this.Test = new KiszTermKapcs(Profile_page.Profil_page.Kiszerelesek[Profile_page.Profil_page.Kiszerelesek.FindIndex(x => x.Liter == liter)].ID, Profile_page.Profil_page.Termekek[Profile_page.Profil_page.Termekek.Count - 1].ID + 1);
        }

        private List<Kiszereles> getKiszereles()
        {
            List<Kiszereles> data = new List<Kiszereles>();
            for (int i = 0; i < Profile_page.Profil_page.KiszTermKapcsolatok.Count; i++)
            {
                if (Profile_page.Profil_page.KiszTermKapcsolatok[i].termekID == this.ID) data.Add(kiszerelesKeres(Profile_page.Profil_page.KiszTermKapcsolatok[i].kiszID));
            }
            return data;
        }

        private Kiszereles kiszerelesKeres(string kiszID)
        {
            for (int i = 0; i < Profile_page.Profil_page.Kiszerelesek.Count; i++)
            {
                if (Profile_page.Profil_page.Kiszerelesek[i].ID == kiszID) return Profile_page.Profil_page.Kiszerelesek[i];
            }
            return null;
        }
    }
}
