using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fozde_termekek.User
{
    public class User
    {
        public int ID { get; set; }
        public string Nev { get; set; }
        public string Jelszo { get; set; }
        public int Jogosultsag { get; set; }

        public User(int id, string nev, string jelszo, int jogosultsag)
        {
            this.ID = id;
            this.Nev = nev;
            this.Jelszo = jelszo;
            this.Jogosultsag = jogosultsag;
        }

        public User()
        {
            this.ID = 0;
        }
    }
}
