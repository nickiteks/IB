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
    public partial class Form_Main_Admin : Form
    {
        public UserBindingModel User { get; set; }
        public Form_Main_Admin(UserLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly UserLogic logic;

        private void button_change_password_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<Form_Password_Replacement>();
            form.User = User;
            form.Show();
        }

        private void Form_Main_Admin_Load(object sender, EventArgs e)
        {
            if (User.FirstLogin)
            {
                var form = Container.Resolve<Form_Password_Replacement>();
                form.User = User;
                form.Show();
            }
            UpdateData();
        }

        private void UpdateData()
        {
            dataGridView1.DataSource = logic.Read(null);
        }

        private void button_add_username_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<Form_Add_Username>();
            form.AfterUpdate = UpdateData;
            form.Show();
        }

        private void button_block_Click(object sender, EventArgs e)
        {            
            var data = dataGridView1.SelectedRows;
            for (int i = 0; i <data.Count;i++)
            {
                logic.BlockUser(Convert.ToInt32(data[i].Cells[0].Value));
            }
            UpdateData();
        }

        private void button_limit_on_Click(object sender, EventArgs e)
        {
            var data = dataGridView1.SelectedRows;
            for (int i = 0; i < data.Count; i++)
            {
                logic.onPasswordRestrictions(Convert.ToInt32(data[i].Cells[0].Value));
            }
            UpdateData();
        }

        private void button_limit_off_Click(object sender, EventArgs e)
        {
            var data = dataGridView1.SelectedRows;
            for (int i = 0; i < data.Count; i++)
            {
                logic.offPasswordRestrictions(Convert.ToInt32(data[i].Cells[0].Value));
            }
            UpdateData();
        }
    }
}
