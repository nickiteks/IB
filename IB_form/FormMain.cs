using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IB_form
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Variant variant = new Variant();
            label_name.Text = variant.getName() + " Вариант:";
            label_variant.Text = variant.getVariant().ToString();
        }

        private void button_save_Click(object sender, EventArgs e)
        {

        }

        private void button_choose_file_Click(object sender, EventArgs e)
        {

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button_password_from_file_Click(object sender, EventArgs e)
        {

        }
    }
}
