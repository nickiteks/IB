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
using System.IO;
using System.Security;

namespace IB_form
{
    public partial class FormMain : Form
    {
        private OpenFileDialog openFileDialog;
        Crypter cryptManager;
        string crypt;
        public FormMain()
        {
            InitializeComponent();
            Variant variant = new Variant();
            label_name.Text = variant.getName() + " Вариант:";
            label_variant.Text = variant.getVariant().ToString();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            File.WriteAllText(openFileDialog.FileName, String.Empty);
            File.WriteAllText(openFileDialog.FileName, richTextBoxOriginal.Text);
        }

        private void button_choose_file_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog.FileName);
                    richTextBoxOriginal.Text = sr.ReadToEnd();
                    sr.Close();
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void button_encrypt_Click(object sender, EventArgs e)
        {
            cryptManager =  new CBCmanager();
            crypt = cryptManager.Crypt(richTextBoxOriginal.Text, int.Parse(textBox_Password.Text));
            richTextBoxCrypt.Text = crypt;            
        }

        private void button_decipher_Click(object sender, EventArgs e)
        {
            richTextBoxEncrypt.Text = cryptManager.Encrypt(crypt, int.Parse(textBox_Password.Text));
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo example = new FormInfo();
            example.Show();
        }

        private void button_password_from_file_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog.FileName);
                    textBox_Password.Text = sr.ReadToEnd();
                    sr.Close();
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
