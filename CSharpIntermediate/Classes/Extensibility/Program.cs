using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
We can use interfaces to change our application’s behaviour by “extending” its code,
rather than changing the existing code.
*/
namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dbMigrator = new DBMigrator(new ConsoleLogger());
            var dbMigrator = new DBMigrator(new FileLogger("C:\\projects\boh.txt"));
            dbMigrator.Migrate();
        }
    }
}
