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
            Display_methods.Controls = this.Controls;
            comboBox1.SelectedValueChanged += delegate (object sender, EventArgs e) { Display_methods.c_box_value_change(comboBox1.SelectedIndex); };
            edit_btn.Click += delegate (object sender, EventArgs e) { Display_methods.visibility_change(false); };
            edit_btn.Click += delegate (object sender, EventArgs e) { DB_operation_methods.ProductEdit(this.Controls); };
            ins_btn.Click += delegate (object sender, EventArgs e) { DB_operation_methods.insert(this.Controls); };
            Display_methods.ins_cbox_feltolt();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Display_methods.c_box_value_set();
            comboBox1.Text = "Válassz...";
            Display_methods.visibility_change(false);
            comboBox2.Text = "Válassz...";
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
                DB.delete(Convert.ToInt32(Kiszerelesek.Find(x=>x.Liter==Convert.ToDouble(comboBox2.Text)).ID), false);
            }
            Display_methods.ins_cbox_feltolt();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Display_methods.c_box_value_change(Termekek.FindIndex(x=>x.Nev==(sender as ListBox).Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = comboBox1.Text;
            if (text != "" || text != "Válassz...") DB.delete(Convert.ToInt32(Termekek.Find(x => x.Nev == text).ID), true);
        }
    }
}