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
    public partial class Form1 : Form
    {
        public static List<KiszTermKapcs> KiszTermKapcsolatok = DB.Kiszereles_termekOlvas();
        public static List<Kiszereles> Kiszerelesek = DB.KiszerelesOlvasas();
        public static List<Termek> Termekek = DB.TermekOlvasas();

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedValueChanged += delegate (object sender, EventArgs e) { c_box_value_change(comboBox1.SelectedIndex); };
            edit_btn.Click += delegate (object sender, EventArgs e) { visibility_change(false); };
            edit_btn.Click += delegate (object sender, EventArgs e) { ProductEdit(); };
            this.Width = 536;
            ins_btn.Click += delegate (object sender, EventArgs e) { insert(); };
            ins_cbox_feltolt();
        }

        public static void UpdateAll()
        {
            KiszTermKapcsolatok = DB.Kiszereles_termekOlvas();
            Kiszerelesek = DB.KiszerelesOlvasas();
            Termekek = DB.TermekOlvasas();
        }

        private void ProductEdit()
        {
            DB.TermekEdit(new Termek(label9.Text, edit_name_txtb.Text,
                        Convert.ToInt32(edit_year_txtb.Text),
                        Convert.ToDouble(edit_strong_txtb.Text),
                        Convert.ToDouble(edit_liter_txtb.Text)), Convert.ToInt32(Kiszerelesek[Kiszerelesek.FindIndex(x => x.Liter == Convert.ToDouble(kisz_cbox.Text))].ID));
            reload();
        }

        private void insert()
        {
            Termek owntermek = new Termek(ins_name.Text,
                        Convert.ToInt32(ins_year.Text),
                        Convert.ToDouble(ins_strong.Text),
                        Convert.ToDouble(ins_liter.Text),
                        Convert.ToDouble(ins_kisz_cbox.Text));
            DB.TermekInsert(new Termek(ins_name.Text,
                        Convert.ToInt32(ins_year.Text),
                        Convert.ToDouble(ins_strong.Text),
                        Convert.ToDouble(ins_liter.Text),
                        Convert.ToDouble(ins_kisz_cbox.Text)));
            reload();
        }

        private void reload()
        {
            UpdateAll();
            c_box_value_set();
            isnertClear();
            C_box_feltoltesek();
            listBox1.Items.Clear();
        }

        private void C_box_feltoltesek()
        {
            c_box_value_set();
            ins_cbox_feltolt();
        }

        private void isnertClear()
        {
            ins_name.Text = "";
            ins_liter.Text = "";
            ins_strong.Text = "";
            ins_year.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c_box_value_set();
            comboBox1.Text = "Válassz...";
            visibility_change(false);
            comboBox2.Text = "Válassz...";
        }

        private void c_box_value_set()
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < Termekek.Count; i++)
            {
                comboBox1.Items.Add(Termekek[i].Nev);
            }
        }

        private void c_box_value_change(int i)
        {
            edit_name_txtb.Text = Termekek[i].Nev;
            edit_year_txtb.Text = Termekek[i].Evjarat.ToString();
            edit_strong_txtb.Text = Termekek[i].Alcohol.ToString();
            edit_liter_txtb.Text = Termekek[i].LiterAr.ToString();
            kiszCboxFeltolt(Termekek[i]);
            label9.Visible = true;
            label9.Text = Termekek[i].ID;
            label9.Visible = false;
            visibility_change(true);
        }

        private void kiszCboxFeltolt(Termek termek)
        {
            for (int i = 0; i < termek.Kiszerelesek.Count; i++)
            {
                kisz_cbox.Items.Add(termek.Kiszerelesek[i].Liter);
            }
        }

        private void ins_cbox_feltolt()
        {
            ins_kisz_cbox.Items.Clear();
            kisz_cbox.Items.Clear();
            comboBox2.Items.Clear();
            for (int i = 0; i < Kiszerelesek.Count; i++)
            {
                ins_kisz_cbox.Items.Add(Kiszerelesek[i].Liter);
                kisz_cbox.Items.Add(Kiszerelesek[i].Liter);
                comboBox2.Items.Add(Kiszerelesek[i].Liter);
            }
        }

        private void visibility_change(bool visible)
        {
            if (visible) this.Width += 250;
            else this.Width -= 250;
            edit_name_txtb.Visible = visible;
            edit_year_txtb.Visible = visible;
            edit_strong_txtb.Visible = visible;
            edit_liter_txtb.Visible = visible;
            label5.Visible = visible;
            label6.Visible = visible;
            label7.Visible = visible;
            label8.Visible = visible;
            edit_btn.Visible = visible;
            comboBox1.Text = "Válassz...";
            comboBox1.Visible = !visible;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Kiszereles mennyiseg = Kiszerelesek.Find(x => x.Liter == Convert.ToDouble(comboBox2.Text));
            for (int i = 0; i < Termekek.Count; i++)
            {
                for (int j = 0; j < Termekek[i].Kiszerelesek.Count; j++)
                {
                    if (Termekek[i].Kiszerelesek[j].Liter == mennyiseg.Liter)
                    {
                        listBox1.Items.Add(Termekek[i].Nev);
                    }
                }
            }
            
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem!="" && listBox1.Items.Count == 0)
            {
                DB.delKisz(Convert.ToInt32(Kiszerelesek.Find(x=>x.Liter==Convert.ToDouble(comboBox2.Text)).ID));
            }
            ins_cbox_feltolt();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c_box_value_change(Termekek.FindIndex(x=>x.Nev==(sender as ListBox).Text));
        }
    }
}