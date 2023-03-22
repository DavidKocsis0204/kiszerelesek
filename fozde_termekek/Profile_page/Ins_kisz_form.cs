using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fozde_termekek.Profile_page
{
    public partial class Ins_kisz_form : Form
    {
        public Ins_kisz_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (kisz_amount.Text != "")
                {
                    DB_classes.POST_op.insert_kisz(kisz_amount.Text);
                }
                kisz_amount.Text = "";
                Helper_functions.Update_All_DB_list();
            }
            catch (Exception a)
            {

                MessageBox.Show($"{a}");
            }
        }
    }
}
