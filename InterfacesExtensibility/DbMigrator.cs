using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesExtensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger; //create private instance of ILogger 

        //dbMigrator knows NOTHING about Console Logger, its only talking to the Interface

        public DbMigrator(ILogger logger) //inject interface into constructor
            //dependency injection!!! --> springboot
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migration started at {0}" +  DateTime.Now); //change , to + to conncatinate string

            //details of migrating the database

            _logger.LogInfo("Migration finished at {0}" + DateTime.Now);

        }
    }
}
