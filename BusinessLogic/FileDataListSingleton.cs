using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace BusinessLogic
{
    public class FileDataListSingleton
    {
        private static FileDataListSingleton instance;
        private readonly string UserFileName = "User.xml";
        private DESCryptoServiceProvider des;

        public List<User> Users { get; set; }

        public FileDataListSingleton(string pass)
        {
            if (des == null)
            {
                try
                {
                    des = new DESCryptoServiceProvider
                    {
                        Mode = CipherMode.CFB
                    };
                    byte[] arr = Encoding.UTF8.GetBytes(pass).ToList().Take(8).ToArray();
                    byte[] arr1 = Encoding.UTF8.GetBytes(pass).ToList().Take(8).ToArray();
                    des.Key = arr;
                    des.IV = arr1;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            if(File.Exists(UserFileName.Replace(".xml", "Encrypt.Xml")))
            {
                DecryptFileUsers();
                Users = LoadUser();
            }
            else
            {
                Users = new List<User>();
                Users.Add(new User()
                {
                    Login = "admin",
                    Password = this.EncryptMd4(""),
                    Admin = true,
                    Block = false,
                    PasswordRestrictions = false,
                    FirstLogin = true,
                });
            }
        }

        public string EncryptMd4(string str)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(str));

            return Convert.ToBase64String(hash);
        }

        private void DecryptFileUsers()
        {
            string data;
            using (StreamReader sr = new StreamReader(UserFileName.Replace(".xml", "Encrypt.Xml")))
            {
                data = sr.ReadToEnd();
            }
            data = Decrypt(data);
            using (StreamWriter sw = new StreamWriter(UserFileName, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(data);
            }
            File.Delete(UserFileName.Replace(".xml", "Encrypt.Xml"));
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
                        PasswordRestrictions = Convert.ToBoolean(el.Element("PasswordRestrictions").Value),
                        FirstLogin = Convert.ToBoolean(el.Element("FirstLogin").Value)
                    });
                }
            }
           
            return list;
        }
        public static FileDataListSingleton GetInstance(string pass)
        {
            if (instance == null)
            {
                instance = new FileDataListSingleton(pass);
            }
            return instance;
        }
        ~FileDataListSingleton()
        {
            SaveUsers();
            EncryptFileUsers();
        }

        private void EncryptFileUsers()
        {
            string data;
            using (StreamReader sr = new StreamReader(UserFileName))
            {
                data = sr.ReadToEnd();
            }
            data = Encrypt(data);
            using (StreamWriter sw = new StreamWriter(UserFileName.Replace(".xml","Encrypt.Xml"), false, System.Text.Encoding.Default))
            {
                sw.WriteLine(data);
            }
            File.Delete(UserFileName);
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
                        new XElement("Block", user.Block),
                        new XElement("Login",user.Login),
                        new XElement("Admin",user.Admin),
                        new XElement("Password", user.Password.ToString()),
                        new XElement("FirstLogin", user.FirstLogin),
                        new XElement("PasswordRestrictions", user.PasswordRestrictions)
                        ));
                }
                XDocument xDocument = new XDocument(xEl);
                xDocument.Save(UserFileName);
            }
        }

        public string Encrypt(string originalString)
        {
            if (string.IsNullOrEmpty(originalString))
            {
                throw new ArgumentNullException
                       ("The string which needs to be encrypted can not be null.");
            }
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                des.CreateEncryptor(des.Key, des.IV), CryptoStreamMode.Write);
            StreamWriter writer = new StreamWriter(cryptoStream);
            writer.Write(originalString);
            writer.Flush();
            cryptoStream.FlushFinalBlock();
            writer.Flush();
            return Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
        }

        public string Decrypt(string cryptedString)
        {
            if (string.IsNullOrEmpty(cryptedString))
            {
                throw new ArgumentNullException
                   ("The string which needs to be decrypted can not be null.");
            }
            MemoryStream memoryStream = new MemoryStream
                    (Convert.FromBase64String(cryptedString));
            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                des.CreateDecryptor(des.Key, des.IV), CryptoStreamMode.Read);
            StreamReader reader = new StreamReader(cryptoStream);
            return reader.ReadToEnd();
        }
    }
}
