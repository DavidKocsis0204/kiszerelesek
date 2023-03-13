using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace fozde_termekek.User
{
    class userDB
    {

        static string utvonal = "server=localhost;database=fozde;uid=root;pwd=;";

        public static User UserLogIn(string nev, string jelszo)
        {
            User loggedUser = new User();
            try
            {
                MySqlConnection kapcsolat = new MySqlConnection(utvonal);
                kapcsolat.Open();
                string sql = $"SELECT * FROM `bejelentkezes` WHERE `nev`='{nev}' AND `jelszo`='{jelszo}'";
                MySqlCommand utasitaskiadas = new MySqlCommand(sql, kapcsolat);
                MySqlDataReader olvasas = utasitaskiadas.ExecuteReader();

                while (olvasas.Read())
                {
                    loggedUser = new User(
                        Convert.ToInt32(olvasas["id"]),
                        olvasas["nev"].ToString(),
                        olvasas["jelszo"].ToString(),
                        Convert.ToInt32(olvasas["jogosultsag"]));
                }
                kapcsolat.Close();

                return loggedUser;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            return new User();
        }

        public static void UserPasswdMod(int userID, string new_passwd)
        {
            string sql = $"UPDATE `bejelentkezes` SET `jelszo`= '{new_passwd}' WHERE `id`='{userID}'";

            try
            {
                MySqlConnection kapcsolat = new MySqlConnection(utvonal);
                kapcsolat.Open();
                MySqlCommand command = new MySqlCommand(sql, kapcsolat);
                command.ExecuteNonQuery();
                kapcsolat.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(sql);
                MessageBox.Show($"{e}");
            }
        }
    }
}
