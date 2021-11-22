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
using System.Security.Cryptography;

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

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo example = new FormInfo();
            example.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            BusinessLogic.SHA1CryptoServiceProvider a = new BusinessLogic.SHA1CryptoServiceProvider();
            var hash = a.ComputeHash(Encoding.UTF8.GetBytes("Help!!!"));
            var sb = new StringBuilder(hash.Length * 2);

            foreach (byte b in hash)
            {
                // can be "x2" if you want lowercase
                sb.Append(b.ToString("X2"));
            }

            Console.WriteLine(sb.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(openFileDialog.FileName, String.Empty);
                File.WriteAllText(openFileDialog.FileName, crypt);
            }
            
        }

        private void button_encrypt_Click(object sender, EventArgs e)
        {
            BusinessLogic.SHA1CryptoServiceProvider a = new BusinessLogic.SHA1CryptoServiceProvider();
            var hash = a.ComputeHash(Encoding.UTF8.GetBytes(richTextBoxOriginal.Text));
            var sb = new StringBuilder(hash.Length * 2);
            foreach (byte b in hash)
            {
                sb.Append(b.ToString("x2"));
            }
            richTextBoxCrypt.Text = sb.ToString();
        }
    }
}
