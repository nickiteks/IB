using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public abstract class Crypter
    {
        protected string IV;
        protected int size;
        protected DES DES = new DES();
        public abstract string Crypt(string text, string key);
        public abstract string Encrypt(string text, string key);

        protected void GenerateIV(int size)
        {
            this.size = size;
            Random r = new Random();
            List<byte> temp = new List<byte>();
            for(int i = 0; i < size; i++)
            {
                temp.Add((byte) r.Next(0,9));
            }
            IV = String.Join("", temp);
        }
        protected List<string> CreateBlocks(string text)
        {
            List<string> strs = new List<string>();
            while (text.Length > size)
            {
                strs.Add(text.Substring(0, size));
                text = text.Remove(0, size);
            }
            if (text.Length > 0)
            {
                strs.Add(text);
            }
            return strs;
        }
    }
}
