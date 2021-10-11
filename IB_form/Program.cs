using BusinessLogic;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormEnterPass());
        }

        public static IUnityContainer BuildUnityContainer(string pass)
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<UserLogic,UserLogic>(Invoke.Constructor(pass));
            return currentContainer;
        }

        public static string Encrypt(string str)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(str));

            return Convert.ToBase64String(hash);
        }

        public static bool Restrictions(string str)
        {
            string regex = @"[a-zA-Z]+";
            var a = Regex.IsMatch(str, regex);
            return (Regex.IsMatch(str, regex, RegexOptions.None));        
        }
    }
}
