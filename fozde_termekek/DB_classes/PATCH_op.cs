using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace fozde_termekek.DB_classes
{
    class PATCH_op
    {
        public static void TermekEdit(Termek produktum, int kiszID)
        {
            string sql = $"UPDATE `termekek` SET `nev`=\"{produktum.Nev}\",`evjarat`={produktum.Evjarat},`erosseg`='{produktum.Alcohol}',`literar`={produktum.LiterAr} WHERE `id`={produktum.ID}";
            Kiszereles_termekUpdate(produktum, kiszID);

            try
            {
                MySqlConnection kapcsolat = new MySqlConnection(Profile_page.Profil_page.utvonal);
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

        public static void Kiszereles_termekUpdate(Termek produktum, int kiszID)
        {
            string sql = $"UPDATE `kiszereleskapcs` SET `kiszID`={kiszID} WHERE `termID`={produktum.ID}";
            try
            {
                MySqlConnection kapcsolat = new MySqlConnection(Profile_page.Profil_page.utvonal);
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
