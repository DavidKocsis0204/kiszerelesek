using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace fozde_termekek.DB_classes
{
    class GET_op
    {
        public static List<Termek> TermekOlvasas()
        {
            List<Termek> termekek = new List<Termek>();
            try
            {
                MySqlConnection kapcsolat = new MySqlConnection(Profile_page.Profil_page.utvonal);
                kapcsolat.Open();
                string sql = "SELECT * FROM termekek";
                MySqlCommand utasitaskiadas = new MySqlCommand(sql, kapcsolat);
                MySqlDataReader olvasas = utasitaskiadas.ExecuteReader();

                while (olvasas.Read())
                {
                    termekek.Add(new Termek(
                        olvasas["id"].ToString(),
                        olvasas["nev"].ToString(),
                        Convert.ToInt32(olvasas["evjarat"]),
                        Convert.ToDouble(olvasas["erosseg"]),
                        Convert.ToDouble(olvasas["literar"])
                        ));
                }
                kapcsolat.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            return termekek;
        }

        public static List<Kiszereles> KiszerelesOlvasas()
        {
            List<Kiszereles> kiszerelesek = new List<Kiszereles>();
            try
            {
                MySqlConnection kapcsolat = new MySqlConnection(Profile_page.Profil_page.utvonal);
                kapcsolat.Open();
                string sql = "SELECT * FROM kiszereles";
                MySqlCommand utasitaskiadas = new MySqlCommand(sql, kapcsolat);
                MySqlDataReader olvasas = utasitaskiadas.ExecuteReader();

                while (olvasas.Read())
                {
                    kiszerelesek.Add(new Kiszereles(
                        olvasas["ID"].ToString(),
                        Convert.ToDouble(olvasas["mennyiseg"])
                        ));
                }
                kapcsolat.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show($"{e}");
            }
            return kiszerelesek;
        }

        public static List<KiszTermKapcs> Kiszereles_termekOlvas()
        {
            List<KiszTermKapcs> kiszerelesek = new List<KiszTermKapcs>();
            try
            {
                MySqlConnection kapcsolat = new MySqlConnection(Profile_page.Profil_page.utvonal);
                kapcsolat.Open();
                string sql = "SELECT * FROM kiszereleskapcs";
                MySqlCommand utasitaskiadas = new MySqlCommand(sql, kapcsolat);
                MySqlDataReader olvasas = utasitaskiadas.ExecuteReader();

                while (olvasas.Read())
                {
                    kiszerelesek.Add(new KiszTermKapcs(
                        olvasas["ID"].ToString(),
                        olvasas["kiszID"].ToString(),
                        olvasas["termID"].ToString()
                        ));
                }

                kapcsolat.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show($"{e}");
            }
            return kiszerelesek;
        }
    }
}
