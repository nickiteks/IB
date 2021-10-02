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
    public partial class Form_Password_Replacement : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly UserLogic logic;
        public UserBindingModel User { get; internal set; }

        public Form_Password_Replacement(UserLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }
        private void button_cansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                Password_wrong_validation();
                return;
            } 
            else if(!User.FirstLogin && !User.Password.Equals(Program.Encrypt(textBox_old_password.Text))) 
            {
                Old_Password_wrong_validation();
                return;
            }
            User.Password = Program.Encrypt(textBox_password_repeat.Text);
            User.FirstLogin = false;
            logic.CreateOrUpdate(User);
            this.Close();
        }


        private void Form_Password_Replacement_Load(object sender, EventArgs e)
        {
            if (User.FirstLogin)
            {
                textBox_old_password.Enabled = false;
            }
        }

        private bool Validation()
        {
            return (!textBox_password.Text.Equals(textBox_password_repeat.Text));
        }
        private void Old_Password_wrong_validation()
        {
            MessageBox.Show("Старый пароль введен не верно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Password_wrong_validation()
        {
            MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
