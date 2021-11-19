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
using BusinessLogic;

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

        private void FormMain_Load(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();
            for(int i = 0; i < 30; i++)
            {
                str.Append("Name");
            }
            richTextBoxOriginal.Text = str.ToString()  ;
            textBox_Password.Text = "123";
            Crypter cryptManager = new CrypterOFB();
            string crypt = cryptManager.Crypt(richTextBoxOriginal.Text, int.Parse(textBox_Password.Text));
            var a = crypt.Length;
            richTextBoxCrypt.Text = crypt;
            richTextBoxEncrypt.Text = cryptManager.Encrypt(crypt, int.Parse(textBox_Password.Text));
        }
    }
}
