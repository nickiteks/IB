using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class OFB : Crypter
    {
        string startIV;
        public OFB()
        {
            this.size = 16;
            GenerateIV(16);
            startIV = IV;
        }
        public override string Crypt(string text, string key)
        {
            List<string> data = CreateBlocks(text);
            List<string> cryptData = new List<string>();
            foreach (var i in data)
            {
                IV = CryptIV(IV, key);
                var temp = DES.xor(i, IV).ToUpper();
                cryptData.Add(temp);
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
                IV = CryptIV(IV, key);
                var temp = DES.xor(i, IV).ToUpper();
                data.Add(temp);
            }
            StringBuilder str = new StringBuilder();
            foreach (var a in data)
            {
                str.Append(a);
            }
            return str.ToString();
        }
    }
}
