using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryandDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Directory --> provides 'static methods' (no need to create an object)
            var path = @"c:\temp\folder1";

            // CreateDirectory --> creates a new directory
            Directory.CreateDirectory(path);

            // GetFiles --> get files from within a directory
            Directory.GetFiles(path);

            // Directory.GetFiles --> search for all files in the directory and any subdirectory (returns a string array)
            var files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            // Directory.GetDirectories --> search only for directories
            var directories = Directory.GetDirectories(path, "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }


            // Exists() --> check if directory exists
            Directory.Exists("...");



            /*
            DirectoryInfo() 
                --> provides 'instance methods' (you need to create an object first)
            */
            var directoryInfo = new DirectoryInfo(path);
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
