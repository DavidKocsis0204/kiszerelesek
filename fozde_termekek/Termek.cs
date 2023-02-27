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
            KiszTermKapcs insToKiszTermKapcs = new KiszTermKapcs(Form1.Kiszerelesek[Form1.Kiszerelesek.FindIndex(x=>x.Liter==liter)].ID, Form1.Termekek[Form1.Termekek.Count-1].ID+1);
            this.Test = new KiszTermKapcs(Form1.Kiszerelesek[Form1.Kiszerelesek.FindIndex(x => x.Liter == liter)].ID, Form1.Termekek[Form1.Termekek.Count - 1].ID + 1);
        }

        private List<Kiszereles> getKiszereles()
        {
            List<Kiszereles> data = new List<Kiszereles>();
            for (int i = 0; i < Form1.KiszTermKapcsolatok.Count; i++)
            {
                if (Form1.KiszTermKapcsolatok[i].termekID == this.ID) data.Add(kiszerelesKeres(Form1.KiszTermKapcsolatok[i].kiszID));
            }
            return data;
        }

        private Kiszereles kiszerelesKeres(string kiszID)
        {
            for (int i = 0; i < Form1.Kiszerelesek.Count; i++)
            {
                if (Form1.Kiszerelesek[i].ID == kiszID) return Form1.Kiszerelesek[i];
            }
            return null;
        }
    }
}
