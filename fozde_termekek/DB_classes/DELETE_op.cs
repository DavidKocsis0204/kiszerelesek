using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace fozde_termekek.DB_classes
{
    class DELETE_op
    {
        public static void delete(int ID, bool isTermek)
        {
            delete_all_kisz_term_kapcs(ID);
            string sql;
            try
            {
                MySqlConnection kapcsolat = new MySqlConnection(Profile_page.Profil_page.utvonal);
                kapcsolat.Open();
                if (!isTermek) sql = $"DELETE FROM `kiszereles` WHERE `ID`={ID}";
                else sql = $"DELETE FROM `termekek` WHERE `ID`={ID}";
                MySqlCommand command = new MySqlCommand(sql, kapcsolat);
                command.ExecuteNonQuery();
                kapcsolat.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show($"{ID}, {isTermek}");
                MessageBox.Show($"{e}");
            }
        }

        public static void delete_all_kisz_term_kapcs(int termID)
        {
            try
            {
                MySqlConnection kapcsolat = new MySqlConnection(Profile_page.Profil_page.utvonal);
                kapcsolat.Open();
                string sql = $"DELETE FROM `kiszereleskapcs` WHERE `termID`={termID}";
                MySqlCommand command = new MySqlCommand(sql, kapcsolat);
                command.ExecuteNonQuery();
                kapcsolat.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show($"{e}");
            }
        }
    }
}
