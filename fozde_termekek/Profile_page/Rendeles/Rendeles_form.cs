using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fozde_termekek.Profile_page.Rendeles
{
    public partial class Rendeles_form : Form
    {
        public Rendeles_form()
        {
            InitializeComponent();
        }

        private void Rendeles_form_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Profil_page.Termekek.Count; i++)
            {
                comboBox1.Items.Add(Profil_page.Termekek[i].Nev);
            }
            for (int i = 0; i < Profil_page.Kiszerelesek.Count; i++)
            {
                comboBox2.Items.Add(Profil_page.Kiszerelesek[i].Liter);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text!="" && comboBox2.Text != "")
            {
                listBox1.Items.Add($"{comboBox1.SelectedItem} - {comboBox2.SelectedItem: 0.00} L" +
                $" Ft {Convert.ToInt32(Profil_page.Termekek[comboBox1.SelectedIndex].LiterAr * Convert.ToDouble(comboBox2.SelectedItem))}");
                comboBox1.Text = "";
                comboBox2.Text = "";
            }
            else
            {
                MessageBox.Show("A rendeléshez minden mezőt ki kell töltenie!");
            }
        }
    }
}
