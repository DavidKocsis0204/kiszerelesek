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
        private static List<KiszTermKapcs> kiszKiszTermKapcsolatok = DB.Kiszereles_termekOlvas();
        private static List<Kiszereles> Kiszerelesek = DB.KiszerelesOlvasas();
        private static List<Termek> Termekek = DB.TermekOlvasas();

        public Rendeles_form()
        {
            InitializeComponent();
        }

        private void Rendeles_form_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Termekek.Count; i++)
            {
                comboBox1.Items.Add(Termekek[i].Nev);
            }
            for (int i = 0; i < Kiszerelesek.Count; i++)
            {
                comboBox2.Items.Add(Kiszerelesek[i].Liter);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"{comboBox1.SelectedItem} - {comboBox2.SelectedItem} " +
                $"Ft {Termekek[comboBox1.SelectedIndex].LiterAr*Convert.ToDouble(comboBox2.SelectedItem)}");
        }
    }
}
