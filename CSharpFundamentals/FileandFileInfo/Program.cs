using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileandFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            File
                --> provides 'static methods' (no need to create an object)
                --> useful for small operations
            */
            var path = @"c:\somefile.jpg";

            /*
            Copy() Method
                - copy file from one directory ('c') to another ('d')
                - 'true' --> if the file already exists, then overwrite it
            */
            File.Copy(@"c:\temp\myfile.jpeg", @"d:\temp\myfile.jpeg", true);


            /*
            Delete() Method
                - provide a path to a file and the 'Delete()' method will delete it
            */
            File.Delete(path);


            // Exists()
            if (File.Exists(path))
            {
                // do something
            }


            // ReadAllText() --> takes a path and returns a string
            var content = File.ReadAllText(path);



            /*
            FileInfo() 
                --> provides 'instance methods' (you need to create an object first)
                --> useful for big operations
            */
            var fileInfo = new FileInfo(path);


            // CopyTo() and Delete()
            fileInfo.CopyTo("...");
            fileInfo.Delete();


            // Exists --> it's not a methods, but a property
            if (fileInfo.Exists)
            {
                // do something
            }
        }
    }
}
