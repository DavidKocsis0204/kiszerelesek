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

        public Form1()
        {
            InitializeComponent();
            Display_methods.Controls = this.Controls;
            comboBox1.SelectedValueChanged += delegate (object sender, EventArgs e) { Display_methods.c_box_value_change(comboBox1.SelectedIndex); };
            edit_btn.Click += delegate (object sender, EventArgs e) { DB_operation_methods.ProductEdit(this.Controls); };
            ins_btn.Click += delegate (object sender, EventArgs e) { DB_operation_methods.insert(this.Controls); };
            Display_methods.ins_cbox_feltolt();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Display_methods.c_box_value_set();
            comboBox1.Text = "Válassz...";
            comboBox2.Text = "Válassz...";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Kiszereles mennyiseg = Profile_page.Profil_page.Kiszerelesek.Find(x => x.Liter == Convert.ToDouble(comboBox2.Text));
            for (int i = 0; i < Profile_page.Profil_page.Termekek.Count; i++)
            {
                for (int j = 0; j < Profile_page.Profil_page.Termekek[i].Kiszerelesek.Count; j++)
                {
                    if (Profile_page.Profil_page.Termekek[i].Kiszerelesek[j].Liter == mennyiseg.Liter)
                    {
                        listBox1.Items.Add(Profile_page.Profil_page.Termekek[i].Nev);
                    }
                }
            }
            
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem!="" && listBox1.Items.Count == 0)
            {
                DB_classes.DELETE_op.delete(Convert.ToInt32(Profile_page.Profil_page.Kiszerelesek.Find(x=>x.Liter==Convert.ToDouble(comboBox2.Text)).ID), false);
            }
            Display_methods.ins_cbox_feltolt();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Display_methods.c_box_value_change(Profile_page.Profil_page.Termekek.FindIndex(x=>x.Nev==(sender as ListBox).Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = comboBox1.Text;
            if (text != "" || text != "Válassz...") DB_classes.DELETE_op.delete(Convert.ToInt32(Profile_page.Profil_page.Termekek.Find(x => x.Nev == text).ID), true);
        }
    }
}