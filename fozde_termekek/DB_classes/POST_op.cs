using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace fozde_termekek.DB_classes
{
    class POST_op
    {
        public static void TermekInsert(Termek produktum)
        {
            try
            {
                MySqlConnection kapcsolat = new MySqlConnection(Profile_page.Profil_page.utvonal);
                kapcsolat.Open();
                string sql = $"INSERT INTO `termekek`(`nev`, `evjarat`, `erosseg`, `literar`) VALUES (\"{produktum.Nev}\",{produktum.Evjarat},{produktum.Alcohol},{produktum.LiterAr})";
                MySqlCommand command = new MySqlCommand(sql, kapcsolat);
                command.ExecuteNonQuery();
                kapcsolat.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show($"{e}");
            }
        }

        public static void Kiszereles_termekWrite(string kiszID, string termID)
        {
            List<Termek> elements = GET_op.TermekOlvasas();
            List<KiszTermKapcs> kiszerelesek = new List<KiszTermKapcs>();
            try
            {
                MySqlConnection kapcsolat = new MySqlConnection( Profile_page.Profil_page.utvonal);
                kapcsolat.Open();
                string sql = $"INSERT INTO `kiszereleskapcs` (`kiszID`, `termID`) VALUES ({kiszID},{elements[elements.Count - 1].ID})";
                MySqlCommand command = new MySqlCommand(sql, kapcsolat);
                command.ExecuteNonQuery();
                kapcsolat.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show($"{e}");
            }
        }

        public static void insert_kisz(string mennyiseg)
        {
            try
            {
                MySqlConnection kapcsolat = new MySqlConnection(Profile_page.Profil_page.utvonal);
                kapcsolat.Open();
                string sql = $"INSERT INTO `kiszereles`(`mennyiseg`) VALUES (\'{mennyiseg}\')";
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
