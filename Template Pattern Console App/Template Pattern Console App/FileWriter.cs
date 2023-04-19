using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Template_Pattern_Console_App
{
    public abstract class FileWriter
    {
        //this cass will have a method Append, but sometimes it will be 
        //appending to an encrypted file and someimes not
        protected string path = "C:\\Users\\qusai\\Desktop\\Projects\\UnityProjects\\Template Pattern Console App\\Documents\\test.txt";

        // Step 1:  Defer this to when we actually write the progra, later OR we could give a default method
        // We are not sure now how or even if the file needs to be decrypted
        protected abstract void DecryptFile();


        // This would be step 2, because you have to decrypt a file before appending to it
        protected virtual void AppendFile(string data)
        {
            using (FileStream fs = File.Open(path, FileMode.Append))
            {
                using (TextWriter tw = new StreamWriter(fs))
                {
                    tw.Write(data);
                }
            }
        }

        // Step 3: we need to potentially reencrypt the file -- but not necessarily
        protected abstract void EncreptFile();

        // This is the "Template Method"

        public void Append(string data)
        {
            // This is where we define A(), B(), C(), D() etc. Some of these may be abstract, some
            // can be virtual, and some can be just plain old methods that will never change
            this.DecryptFile();
            this.AppendFile(data);
            this.EncreptFile();

        }

    }
}
