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

        public Termek(string iD, string nev, int evjarat, double alcohol, double literAr)
        {
            ID = iD;
            Nev = nev;
            Evjarat = evjarat;
            Alcohol = alcohol;
            LiterAr = literAr;
        }
        
        public Termek(string nev, int evjarat, double alcohol, double literar)
        {
            Nev = nev;
            Evjarat = evjarat;
            Alcohol = alcohol;
            LiterAr = literar;
        }

        private List<Kiszereles> getKiszereles()
        {
            List<Kiszereles> data = new List<Kiszereles>();
            for (int i = 0; i < Form1.KiszTermKapcsolatok.Count; i++)
            {
                if (Form1.KiszTermKapcsolatok[i].termekID == this.ID) data.Add(Form1.Kiszerelesek[Convert.ToInt32(Form1.KiszTermKapcsolatok[i].kiszID)]));
            }
            return data;
        }
    }
}
