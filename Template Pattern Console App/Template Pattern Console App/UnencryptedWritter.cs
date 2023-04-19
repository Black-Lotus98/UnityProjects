using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Template_Pattern_Console_App
{
    internal class UnencryptedWritter:FileWriter
    {
        public UnencryptedWritter(string aPath)
        {
            this.path = aPath;
        }
        // Step 1 we dont need to do anything
        protected override void DecryptFile()
        {
            // we dont need anything here, because the file is not encrepted
            // but we DO NEED to make this method
        }


        // Step 2 we dont need to write anything because we inhrit it from FileWritter


        // Step 3 we dont need to do anything
        protected override void EncreptFile()
        {
            // we dont need anything here
            // but we DO NEED to make this method
        }

    }
}
