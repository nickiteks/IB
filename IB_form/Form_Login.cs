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
    public partial class Form_Login : Form
    {
        public Form_Login(UserLogic logic)
        {
            InitializeComponent();
            this.logic = logic;

        }

        private int countWrongLogin = 0;
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly UserLogic logic;
        
        public void User_not_found()
        {
            MessageBox.Show("Неверное имя пользователя","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        public void Password_wrong()
        {
            MessageBox.Show("Неверный пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Password_wrong_validation()
        {
            MessageBox.Show("Неверный формат пароля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void User_Block()
        {
            MessageBox.Show("Пользователь заблокирован", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public string Encrypt(string str)
        {
            return str;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            var user = logic.Read(new UserBindingModel()
            {
                Login = textBox_login.Text
            });
            if (user.Count < 1)
            {
                User_not_found();
            }
            if (user[0].Block)
            {
                User_Block();
            }
            else
            {
                if (Encrypt(textBox_password.Text).Equals(user[0].Password))
                {
                    if (user[0].FirstLogin)
                    {
                        var form = Container.Resolve<Form_Password_Replacement>();
                        form.User = user[0];
                        form.ShowDialog();
                    } else
                    if (user[0].Admin)
                    {
                        var form = Container.Resolve<Form_Main_Admin>();
                        form.User = user[0];
                        form.ShowDialog();
                    }
                    else
                    {
                        var form = Container.Resolve<Form_User>();
                        form.user = user[0];
                        form.ShowDialog();
                    }
                }
                else
                {
                    Password_wrong();
                    countWrongLogin++;
                    if(countWrongLogin >= 3)
                    {
                        this.Close();
                    }
                }
            }
        }
    }
}
