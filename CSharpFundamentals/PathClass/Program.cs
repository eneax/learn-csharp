using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Projects\CsharpFundamentals\HelloWorld\HelloWorld.sln";

            // Get the extension at the end of the path '.sln'
            Path.GetExtension(path);

            // Get the file name
            Path.GetFileName(path);
            Path.GetFileNameWithoutExtension(path);

            // Get the directory name
            Path.GetDirectoryName(path);
        }
    }
}
