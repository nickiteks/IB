using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CBC : Crypter
    {
        string startIV;
        public CBC()
        {
            this.size = 16;
            GenerateIV(16);
            startIV = IV;
        }
        public override string Crypt(string text, string key)
        {
            List<string> data = CreateBlocks(text);
            List<string> cryptData = new List<string>();
            foreach(var i in data)
            {
                IV = DES.xor(i, IV).ToUpper();
                IV = CryptIV(IV, key);
                cryptData.Add(IV);
            }
            StringBuilder str = new StringBuilder();
            foreach (var a in cryptData)
            {
                str.Append(a);
            }
            return str.ToString();
        }

        private string CryptIV(string data, string key)
        {         
            return DES.encrypt(data, key);
        }

        public override string Encrypt(string text, string key)
        {
            IV = startIV;
            List<string> data = new List<string>();
            List<string> cryptData = CreateBlocks(text);
            foreach (var i in cryptData)
            {
                var temp = deCryptIV(i, key);
                IV = DES.xor(IV, temp).ToUpper();
                data.Add(IV);
                IV = i;
            }
            StringBuilder str = new StringBuilder();
            foreach (var a in data)
            {
                str.Append(a);
            }
            return str.ToString();
        }
        private string deCryptIV(string data, string key)
        {
            return DES.decrypt(data, key);
        }
    }
}
