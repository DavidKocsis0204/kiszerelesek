using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace fozde_termekek
{
    class DB
    {
        static string utvonal = "server=localhost;database=fozde;uid=root;pwd=;";

        public static List<Termek> TermekOlvasas()
        {
            List<Termek> termekek = new List<Termek>();
            try
            {
                MySqlConnection kapcsolat = new MySqlConnection(utvonal);
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
                MySqlConnection kapcsolat = new MySqlConnection(utvonal);
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
                MySqlConnection kapcsolat = new MySqlConnection(utvonal);
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

        public static void TermekInsert(Termek produktum)
        {
            try
            {
                MySqlConnection kapcsolat = new MySqlConnection(utvonal);
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

        public static void TermekEdit(Termek produktum, int kiszID)
        {
            string sql = $"UPDATE `termekek` SET `nev`=\"{produktum.Nev}\",`evjarat`={produktum.Evjarat},`erosseg`='{produktum.Alcohol}',`literar`={produktum.LiterAr} WHERE `id`={produktum.ID}";
            Kiszereles_termekUpdate(produktum, kiszID);

            try
            {
                MySqlConnection kapcsolat = new MySqlConnection(utvonal);
                kapcsolat.Open();
                //string sql = $"UPDATE `termekek` SET `nev`=\"{produktum.Nev}\",`evjarat`={produktum.Evjarat},`erosseg`={produktum.Alcohol},`literar`={produktum.LiterAr} WHERE `id`={produktum.ID}";
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

        public static void Kiszereles_termekWrite(string kiszID, string termID)
        {
            List<Termek> elements = TermekOlvasas();
            List<KiszTermKapcs> kiszerelesek = new List<KiszTermKapcs>();
            try
            {
                MySqlConnection kapcsolat = new MySqlConnection(utvonal);
                kapcsolat.Open();
                string sql = $"INSERT INTO `kiszereleskapcs` (`kiszID`, `termID`) VALUES ({kiszID},{elements[elements.Count-1].ID})";
                MySqlCommand command = new MySqlCommand(sql, kapcsolat);
                command.ExecuteNonQuery();
                kapcsolat.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show($"{e}");
            }
        }

        public static void delKisz(int ID)
        {
            try
            {
                MySqlConnection kapcsolat = new MySqlConnection(utvonal);
                kapcsolat.Open();
                string sql = $"DELETE FROM `kiszereles` WHERE `ID`={ID}";
                MySqlCommand command = new MySqlCommand(sql, kapcsolat);
                command.ExecuteNonQuery();
                kapcsolat.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("nem jó");
                MessageBox.Show($"{e}");
            }
        }
    }
}
