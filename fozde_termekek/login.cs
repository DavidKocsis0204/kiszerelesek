using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fozde_termekek
{
    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            User.User user = User.userDB.UserLogIn(log_name.Text.ToString(), log_passwd.Text.ToString());
            if (user.ID == 0) MessageBox.Show("A felhasználó nem létezik!");
            else acces_to_profile(user);
            clear_inputs();
        }

        private void clear_inputs()
        {
            log_name.Text = "";
            log_passwd.Text = "";
        }

        private void acces_to_profile(User.User logged_user)
        {
            Profile_page.Profil_page profil = new Profile_page.Profil_page(logged_user);
            profil.Show();
            this.Hide();
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
