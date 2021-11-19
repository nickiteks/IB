using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Collections;

namespace BusinessLogic
{
    public class CryptManagerCBC : Crypter
    {
        public CryptManagerCBC()
        {
            GenerateIV(16);
        }
        public override string Crypt(string text,int key)
        {
            key = key % 256;
            BitArray dataBit = new BitArray(16);
            List<byte> data = new List<byte>();
            List<byte> cryptData = new List<byte>();
            List<byte> logByte = new List<byte>(); 
            data.AddRange(this.ConvertToByteArray(text));
            while(data.Count % 16 > 0)
            {
                data.Add(0);
            }
            Console.WriteLine();
            for(int i=0;i < data.Count; i++)
            {
                int a = (int)data[i] ^ (int)IV[i];
                a = a + key;
                a = a % 256;
                a = Math.Abs(((int)data[i] ^ (int)IV[i]) + key) % 256;
                cryptData.Add((byte) a); 
            }
            return ConvertToString(cryptData);
        }

        public override string Encrypt(string text, int key)
        {
            BitArray dataBit = new BitArray(16);
            List<byte> data = new List<byte>();
            List<byte> cryptData = new List<byte>();
            cryptData.AddRange(ConvertToByteArray(text));
            Print(cryptData);
            for (int i = 0; i < cryptData.Count; i++)
            {
                int a = cryptData[i] - key;
                if(a < 0)
                {
                    a += 256;
                }
                a = a ^ (int)IV[i];
                data.Add((byte) a);
            }
            return ConvertToString(data);
        }

    }
}
