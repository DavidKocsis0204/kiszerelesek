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
        public static string utvonal = "server=localhost;database=fozde;uid=root;pwd=;";
        public static List<KiszTermKapcs> KiszTermKapcsolatok = DB_classes.GET_op.Kiszereles_termekOlvas();
        public static List<Kiszereles> Kiszerelesek = DB_classes.GET_op.KiszerelesOlvasas();
        public static List<Termek> Termekek = DB_classes.GET_op.TermekOlvasas();

        public User.User current_user = new User.User();

        public Profil_page(User.User user)
        {
            InitializeComponent();
            current_user = user;
            this.Text = user.Nev;
            user_profil_privilege_set(current_user.Jogosultsag);
        }

        private void user_profil_privilege_set(int priv)
        {  
            if (priv == 2) kisz_term_btn.Visible = true;
            if (priv == 2) new_kisz_btn.Visible = true;
            if (priv == 2) rendeles_btn.Visible = false;
        }

        private void Profil_page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void edit_passwd_btn_Click(object sender, EventArgs e)
        {
            Profil_Passwd_Mod.Passwd_Mod pass_mod = new Profil_Passwd_Mod.Passwd_Mod(current_user.Jelszo, current_user);
            pass_mod.Show();
        }

        private void kisz_term_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void new_kisz_btn_Click(object sender, EventArgs e)
        {
            Ins_kisz_form inskiszform = new Ins_kisz_form();
            inskiszform.Show();
        }

        private void rendeles_btn_Click(object sender, EventArgs e)
        {
            Rendeles.Rendeles_form rendeles_form = new Rendeles.Rendeles_form();
            rendeles_form.Show();
        }
    }
}
