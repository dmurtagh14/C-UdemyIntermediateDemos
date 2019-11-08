using System;

namespace InterfacesExtensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("C:\\C#Udemy2\\log.txt")); //dbMigrator needs an instance of ILogger, but we can pass in ConsoleLogger here

            dbMigrator.Migrate();
        }
    }
}
