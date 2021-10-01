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
    public partial class Form_User : Form
    {
        public Form_User()
        {
            InitializeComponent();
        }
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly UserLogic logic;
        public UserBindingModel user { get; set; }

        private void button_change_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<Form_Password_Replacement>();
            form.User = user;
            form.Show();
        }
    }
}
