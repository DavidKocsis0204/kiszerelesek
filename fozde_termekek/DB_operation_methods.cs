using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fozde_termekek
{
    public class DB_operation_methods
    {
        public static void Update_All_DB_list()
        {
            Form1.KiszTermKapcsolatok = DB.Kiszereles_termekOlvas();
            Form1.Kiszerelesek = DB.KiszerelesOlvasas();
            Form1.Termekek = DB.TermekOlvasas();
        }

        public static void ProductEdit(Control.ControlCollection controls)
        {
            DB.TermekEdit(new Termek(Helper_functions.find_lbl("label9", controls).Text, Helper_functions.find_tbox("edit_name_txtb", controls).Text,
                        Convert.ToInt32(Helper_functions.find_tbox("edit_year_txtb", controls).Text),
                        Convert.ToDouble(Helper_functions.find_tbox("edit_strong_txtb", controls).Text),
                        Convert.ToDouble(Helper_functions.find_tbox("edit_liter_txtb", controls).Text)),
                        Convert.ToInt32(Form1.Kiszerelesek[Form1.Kiszerelesek.FindIndex(x => x.Liter == Convert.ToDouble(Helper_functions.find_tbox("kisz_cbox", controls).Text))].ID));
            Display_methods.reload();
        }

        public static void insert(Control.ControlCollection controls)
        {
            Termek owntermek = new Termek(Helper_functions.find_tbox("ins_name", controls).Text,
                        Convert.ToInt32(Helper_functions.find_tbox("ins_year", controls).Text),
                        Convert.ToDouble(Helper_functions.find_tbox("ins_strong", controls).Text),
                        Convert.ToDouble(Helper_functions.find_tbox("ins_liter", controls).Text),
                        Convert.ToDouble(Helper_functions.find_tbox("ins_kisz_cbox", controls).Text));
            DB.TermekInsert(new Termek(Helper_functions.find_tbox("ins_name", controls).Text,
                        Convert.ToInt32(Helper_functions.find_tbox("ins_year", controls).Text),
                        Convert.ToDouble(Helper_functions.find_tbox("ins_strong", controls).Text),
                        Convert.ToDouble(Helper_functions.find_tbox("ins_liter", controls).Text),
                        Convert.ToDouble(Helper_functions.find_tbox("ins_kisz_cbox", controls).Text)));
            Display_methods.reload();
        }
    }
}
