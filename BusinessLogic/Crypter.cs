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
        protected byte[] IV;
        protected int size;
        public abstract string Crypt(string text, int key);
        public abstract string Encrypt(string text, int key);

        protected void GenerateIV(int size)
        {
            this.size = size;
            Random r = new Random(1);
            IV = new byte[size];
            for(int i = 0; i < size; i++)
            {
                IV[i] =(byte) r.Next(0,255);
            }
        }

        protected void Print(IEnumerable<byte> data)
        {
            foreach (var a in data)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        protected void Print(IEnumerable<int> data)
        {
            foreach (var a in data)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        protected List<byte> ConvertToByteArray(string str)
        {
            List<byte> data = new List<byte>();
            foreach (var a in str)
            {
                data.Add((byte)a);
            }
            while (data.Count < size)
            {
                data.Add(0);
            }
            return data;
        }

        protected string ConvertToString(IEnumerable<byte> data)
        {
            StringBuilder str = new StringBuilder();
            foreach (var a in data)
            {
                str.Append((char)a);
            }
            return str.ToString();
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
        protected byte[] XOR(byte[] a, byte[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = (byte)((int)a[i] ^ (int)b[i]);
            }
            return a;
        }

        protected void Print(IEnumerable<IEnumerable<byte>> data)
        {
            foreach (var a in data)
            {
                foreach( var b in a)
                {
                    Console.Write(b.ToString() + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        protected byte[] CloneArray(byte[] data)
        {
            byte[] Clone = new byte[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                Clone[i] = data[i];
            }
            return Clone;
        }
    }
}
