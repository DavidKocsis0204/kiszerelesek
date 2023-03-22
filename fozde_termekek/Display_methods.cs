using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fozde_termekek
{   
    public class Display_methods
    {
        public static Control.ControlCollection Controls;

        public static void reload()
        {
            Helper_functions.Update_All_DB_list();
            c_box_value_set();
            insertClear();
            C_box_feltoltesek();
            Helper_functions.find_lbox("listBox1", Controls).Items.Clear();
        }

        public static void C_box_feltoltesek()
        {
            c_box_value_set();
            ins_cbox_feltolt();
        }

        public static void insertClear()
        {
            Helper_functions.find_tbox("ins_name", Controls).Text = "";
            Helper_functions.find_tbox("ins_liter", Controls).Text = "";
            Helper_functions.find_tbox("ins_strong", Controls).Text = "";
            Helper_functions.find_tbox("ins_year", Controls).Text = "";
        }

        public static void c_box_value_set()
        {
            ComboBox c_box = Helper_functions.find_cbox("comboBox1", Controls);
            c_box.Items.Clear();
            for (int i = 0; i < Profile_page.Profil_page.Termekek.Count; i++)
            {
                c_box.Items.Add(Profile_page.Profil_page.Termekek[i].Nev);
            }
        }

        public static void c_box_value_change(int i)
        {
            Helper_functions.find_tbox("edit_name_txtb", Controls).Text = Profile_page.Profil_page.Termekek[i].Nev;
            Helper_functions.find_tbox("edit_year_txtb", Controls).Text = Profile_page.Profil_page.Termekek[i].Evjarat.ToString();
            Helper_functions.find_tbox("edit_strong_txtb", Controls).Text = Profile_page.Profil_page.Termekek[i].Alcohol.ToString();
            Helper_functions.find_tbox("edit_liter_txtb", Controls).Text = Profile_page.Profil_page.Termekek[i].LiterAr.ToString();
            kiszCboxFeltolt(Profile_page.Profil_page.Termekek[i]);
            Helper_functions.find_lbl("label9", Controls).Visible = true;
            Helper_functions.find_lbl("label9", Controls).Text = Profile_page.Profil_page.Termekek[i].ID;
            Helper_functions.find_lbl("label9", Controls).Visible = false;
        }

        public static void kiszCboxFeltolt(Termek termek)
        {
            ComboBox c_box = Helper_functions.find_cbox("kisz_cbox", Controls);
            for (int i = 0; i < termek.Kiszerelesek.Count; i++)
            {
                c_box.Items.Add(termek.Kiszerelesek[i].Liter);
            }
        }

        public static void ins_cbox_feltolt()
        {
            Helper_functions.find_cbox("ins_kisz_cbox", Controls).Items.Clear();
            Helper_functions.find_cbox("kisz_cbox", Controls).Items.Clear();
            Helper_functions.find_cbox("comboBox2", Controls).Items.Clear();
            for (int i = 0; i < Profile_page.Profil_page.Kiszerelesek.Count; i++)
            {
                Helper_functions.find_cbox("ins_kisz_cbox", Controls).Items.Add(Profile_page.Profil_page.Kiszerelesek[i].Liter);
                Helper_functions.find_cbox("kisz_cbox", Controls).Items.Add(Profile_page.Profil_page.Kiszerelesek[i].Liter);
                Helper_functions.find_cbox("comboBox2", Controls).Items.Add(Profile_page.Profil_page.Kiszerelesek[i].Liter);
            }
        }
    }
}
