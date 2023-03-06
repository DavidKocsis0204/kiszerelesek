using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fozde_termekek
{
    class Helper_functions
    {
        public static TextBox find_tbox(string name, Control.ControlCollection controls)
        {
            return controls.Find(name, true)[0] as TextBox;
        }

        public static Label find_lbl(string name, Control.ControlCollection controls)
        {
            return controls.Find(name, true)[0] as Label;
        }

        public static ComboBox find_cbox(string name, Control.ControlCollection controls)
        {
            return controls.Find(name, true)[0] as ComboBox;
        }

        public static ListBox find_lbox(string name, Control.ControlCollection controls)
        {
            return controls.Find(name, true)[0] as ListBox;
        }

        public static Button find_btn(string name, Control.ControlCollection controls)
        {
            return controls.Find(name, true)[0] as Button;
        }
    }
}
