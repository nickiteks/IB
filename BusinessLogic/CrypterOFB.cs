using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CrypterOFB : Crypter
    {
        byte[] startIV;
        public CrypterOFB()
        {
            GenerateIV(16);
            startIV = CloneArray(IV);

        }
        public override string Crypt(string text, int key)
        {
            var data = CreateBlocks(text);
            List<List<byte>> cryptData = new List<List<byte>>();
            for(int i = 0; i < data.Count(); i++)
            {
                CryptIV(IV, key);
                cryptData.Add(XOR(ConvertToByteArray(data[i]).ToArray(), IV).ToList());
            }
            StringBuilder str = new StringBuilder();
            foreach(var a in cryptData)
            {
                str.Append(ConvertToString(a));
            }
            Print(cryptData);

            return str.ToString();
        }

        private void CryptIV(byte[] list,int key)
        {
            Print(IV);
            for (int i = 0; i < list.Count(); i++)
            {
                list[i] =(byte) (((int) list[i] + key)%256);
            }
        }

        protected byte[] CloneArray(byte[] data)
        {
            byte[] Clone = new byte[data.Length];
            for(int i = 0;i< data.Length; i++)
            {
                Clone[i] = data[i];
            }
            return Clone;
        }

        public override string Encrypt(string text, int key)
        {
            IV = CloneArray(startIV);
            
            key %= 256;
            var cryptData = CreateBlocks(text);
            List<List<byte>> data = new List<List<byte>>();
            for (int i = 0; i < cryptData.Count(); i++)
            {
                CryptIV(IV, key);
                data.Add(XOR(ConvertToByteArray(cryptData[i]).ToArray(), IV).ToList());
                Print(IV);
            }
            Print(data);
            StringBuilder str = new StringBuilder();
            foreach (var a in data)
            {
                str.Append(ConvertToString(a));
            }
            return str.ToString();
        }
    }
}
