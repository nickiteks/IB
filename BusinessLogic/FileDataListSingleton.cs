using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLogic
{
    public class FileDataListSingleton
    {
        private static FileDataListSingleton instance;
        private readonly string UserFileName = "User.xml";

        public List<User> Users { get; set; }

        private FileDataListSingleton()
        {
            Users = LoadUser();
        }

        private List<User> LoadUser()
        {
            var list = new List<User>();
            if (File.Exists(UserFileName))
            {
                XDocument xDocument = XDocument.Load(UserFileName);
                var xElements = xDocument.Root.Elements("User").ToList();
                foreach (var el in xElements)
                {
                    list.Add(new User
                    {
                        Id = Convert.ToInt32(el.Attribute("Id").Value),
                        Block = Convert.ToBoolean(el.Element("Block").Value),
                        Login = el.Element("Login").Value,
                        Admin = Convert.ToBoolean(el.Element("Admin").Value),
                        Password = el.Element("Password").Value,
                        PasswordRestrictions = Convert.ToBoolean(el.Element("PasswordRestrictions").Value)
                    });
                }
            }
            else
            {
                list.Add(new User()
                {
                    Login = "admin",
                    Password = "1",
                    Admin = true,
                    Block  = false,
                    PasswordRestrictions = false,
                });
            }
            return list;
        }
        public static FileDataListSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new FileDataListSingleton();
            }
            return instance;
        }
        ~FileDataListSingleton()
        {
            SaveUsers();
        }

        private void SaveUsers()
        {
            if(Users != null)
            {
                var xEl = new XElement("Users");
                foreach(var user in Users)
                {
                    xEl.Add(new XElement("User",
                        new XAttribute("Id", user.Id),
                        new XElement("Block",user.Block),
                        new XElement("Login",user.Login),
                        new XElement("Admin",user.Admin),
                        new XElement("Password", user.Password.ToString()),
                        new XElement("PasswordRestrictions", user.PasswordRestrictions)
                        ));
                }
                XDocument xDocument = new XDocument(xEl);
                xDocument.Save(UserFileName);
            }
        }
    }
}
