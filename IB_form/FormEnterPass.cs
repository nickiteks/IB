using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace IB_form
{
    public partial class FormEnterPass : Form
    {
        private string salt = "random";
        public FormEnterPass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cont = Program.BuildUnityContainer(textBox1.Text+salt);
            var form = cont.Resolve<Form_Login>();
            form.Show();
            //this.Close();
        }
    }
}
