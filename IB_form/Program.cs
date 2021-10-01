using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace IB_form
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Login());
        }

        private static object BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<UserLogic>(new HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}
