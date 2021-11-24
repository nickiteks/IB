using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CBCmanager : Crypter
    {
        byte[] startIV;
        public CBCmanager()
        {
            this.size = 16;
            GenerateIV(16);
            startIV = CloneArray(IV);
        }
        public override string Crypt(string text, string key)
        {
            var data = CreateBlocks(text);
            List<List<byte>> cryptData = new List<List<byte>>();
            for (int i = 0; i < data.Count(); i++)
            {
                var prepdata = ConvertToByteArray(data[i]);
                Print(IV.ToList());
                IV = XOR(IV, prepdata.ToArray());
                CryptIV(IV, key);
                cryptData.Add(IV.ToList());
            }
            StringBuilder str = new StringBuilder();
            foreach (var a in cryptData)
            {
                str.Append(ConvertToString(a));
            }
            return str.ToString();
        }

        private void CryptIV(byte[] list, string key)
        {
            DES dES = new DES();
            list = ConvertToByteArray(dES.EncryptDES(ConvertToString(list), key)).ToArray();
        }

        public override string Encrypt(string text, string key)
        {
            IV = CloneArray(startIV);
            var temp = new byte();
            var cryptData = CreateBlocks(text);
            List<List<byte>> data = new List<List<byte>>();
            for (int i = 0; i < cryptData.Count(); i++)
            {
                data.Add(EncryptBlock(ConvertToByteArray(cryptData[i]).ToArray(),key).ToList());
                data[i] = XOR(IV, data[i].ToArray()).ToList();
                Print(data[i]);
                IV = ConvertToByteArray(cryptData[i]).ToArray();
            }
            StringBuilder str = new StringBuilder();
            foreach (var a in data)
            {
                str.Append(ConvertToString(a));
            }
            return str.ToString();
        }

        private byte[] EncryptBlock(byte[] data, string key)
        {
            DES dES = new DES();
            return ConvertToByteArray(dES.EncryptDES(ConvertToString(data), key)).ToArray();
        }
    }
}
