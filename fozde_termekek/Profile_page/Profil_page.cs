using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fozde_termekek.Profile_page
{
    public partial class Profil_page : Form
    {
        public User.User current_user = new User.User();

        public Profil_page(User.User user)
        {
            InitializeComponent();
            current_user = user;
            this.Text = user.Nev;
        }



        private void Profil_page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void edit_passwd_btn_Click(object sender, EventArgs e)
        {
            Profil_Passwd_Mod.Passwd_Mod pass_mod = new Profil_Passwd_Mod.Passwd_Mod(current_user.Jelszo);
            pass_mod.Show();
        }
    }
}
