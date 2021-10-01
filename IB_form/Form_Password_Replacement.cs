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
        public Form_Password_Replacement(UserLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly UserLogic logic;
        private void button_cansel_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<Form_Main_Admin>();
            form.Show();
            this.Hide();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            
        }
    }
}
