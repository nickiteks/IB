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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

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
    }
}
