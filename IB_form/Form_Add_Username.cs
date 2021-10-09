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
using Unity;

namespace IB_form
{
    public partial class Form_Add_Username : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public Action AfterUpdate { get; internal set; }

        private readonly UserLogic logic;
        public Form_Add_Username(UserLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            logic.CreateOrUpdate(new UserBindingModel()
            {
                Admin = false,
                Block = false,
                FirstLogin = true,
                Login = textBox_username.Text,
                Password = Program.Encrypt(""),
            });
            AfterUpdate.Invoke();
            this.Close();
        }
    }
}
