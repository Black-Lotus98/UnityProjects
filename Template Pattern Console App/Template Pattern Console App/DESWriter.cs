using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Template_Pattern_Console_App
{
    public class DESWriter:FileWriter
    {

        private const string key = "12345678";


        public DESWriter(string aPath)
        {
            this.path = aPath;
        }

        protected override void DecryptFile()
        {
            if(File.Exists(this.path))
            {
                using (FileStream fs = File.Open(path, FileMode.OpenOrCreate))
                {
                    DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
                    DES.Key = ASCIIEncoding.ASCII.GetBytes(key);
                    DES.IV = ASCIIEncoding.ASCII.GetBytes(key);
                    ICryptoTransform desDecrypt = DES.CreateDecryptor();
                    CryptoStream cryptoStreamDecr = new CryptoStream(fs, desDecrypt, CryptoStreamMode.Write);
                    StreamWriter fsDecrypted = new StreamWriter("C:\\Users\\qusai\\Desktop\\Projects\\UnityProjects\\Template Pattern Console App\\Documents\\temp.txt");
                    fsDecrypted.Write(new StreamReader(cryptoStreamDecr).ReadToEnd());
                    fsDecrypted.Flush();
                    fsDecrypted.Close();

                }
            }
        }

        protected override void AppendFile(string data)
        {
            using (FileStream fs = File.Open("C:\\Users\\qusai\\Desktop\\Projects\\UnityProjects\\Template Pattern Console App\\Documents\\temp.txt", FileMode.Append))
            {
                using (TextWriter tw = new StreamWriter(fs))
                {
                    tw.Write(data);
                }
            }
        }

        // The AppenFile does not need to be overridden except for the path -- which is temp.txt now

        protected override void EncreptFile()
        {
            if (File.Exists(this.path))
            {
                using (FileStream fs = File.Open(path, FileMode.Open))
                {
                    FileStream fsEncrypted = new FileStream(path, FileMode.Create, FileAccess.Write);
                    
                    DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
                    DES.Key = ASCIIEncoding.ASCII.GetBytes(key);
                    DES.IV = ASCIIEncoding.ASCII.GetBytes(key);
                    ICryptoTransform desEcrypt = DES.CreateEncryptor();
                    CryptoStream cryptoStreamEncr = new CryptoStream(fs, desEcrypt, CryptoStreamMode.Write);
                    byte[] byteArrayInput = new byte[fs.Length];
                    cryptoStreamEncr.Write(byteArrayInput, 0, byteArrayInput.Length);
                    cryptoStreamEncr.Close();
                    fs.Close();
                    fsEncrypted.Close();

                }
            }
        }




    }
}
