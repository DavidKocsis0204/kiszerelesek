using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fozde_termekek.Profile_page.Profil_Passwd_Mod
{
    public partial class Passwd_Mod : Form
    {
        public string Old_pass { get; set; }

        public Passwd_Mod(string old_passwd)
        {
            InitializeComponent();
            this.Old_pass = old_passwd;
        }

        private void Passwd_Mod_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void passmod_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
