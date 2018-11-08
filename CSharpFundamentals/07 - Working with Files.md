# Working with Files
All the classes that we need to work with files are located into the namespace 'System.IO'.


## File and FileInfo Classes

They provide methods for creating, copying, deleting, moving and opening of files.
- FileInfo provides 'instance' methods
- File provides 'static' methods

When you use File, the operative system does some checking to verify that you have access to a file.
So if you have a lot of operations, this process will affect the performance of your application.
With FileInfo class, the security check is done only during the creation of the FileInfo object.


## Directory and DirectoryInfo
- DirectoryInfo provides 'instance' methods
- Directory provides 'static' methods


## Path Class
It provides methods to work with a string that contains a file or a directory path information.