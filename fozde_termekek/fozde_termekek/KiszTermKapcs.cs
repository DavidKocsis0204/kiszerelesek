using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fozde_termekek
{
    public class KiszTermKapcs
    {
        public string ID;
        public string kiszID;
        public string termekID;

        public KiszTermKapcs(string iD, string kiszID, string termekID)
        {
            ID = iD;
            this.kiszID = kiszID;
            this.termekID = termekID;
        }

    }
}
