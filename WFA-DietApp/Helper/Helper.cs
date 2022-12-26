using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_DietApp.Helper
{
    static class Helper
    {
        public static void FormTemizle(Control.ControlCollection koleksiyon)
        {
            foreach (Control item in koleksiyon)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1;
                }
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
                else if (item is ListBox)
                {

                    FormTemizle(((ListBox)item).Controls);

                }
                else if (item is ListView)
                {
                    FormTemizle(((ListView)item).Controls);
                }

                else if (item is Panel)
                {
                    FormTemizle(((Panel)item).Controls);
                }
            }
        }
    }
}
