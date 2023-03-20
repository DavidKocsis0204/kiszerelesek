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
        private User.User curr_usr { get; set; }

        public Passwd_Mod(string old_passwd, User.User current_user)
        {
            InitializeComponent();
            this.Old_pass = old_passwd;
            this.curr_usr = current_user;
        }

        private void passmod_btn_Click(object sender, EventArgs e)
        {
            if (new_pass_1.Text != new_pass_2.Text && new_pass_1.Text!="" && new_pass_2.Text!="") MessageBox.Show("A két jelszó nem egyezik!");
            else 
            {
                User.userDB.UserPasswdMod(curr_usr.ID, new_pass_1.Text);
                this.Close();
            } 
        }
    }
}
