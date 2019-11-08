using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionDemo
{
    class DbMigrator
    {
        private readonly Logger _logger;
        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void migrate()
        {
            _logger.Log("We are migrating adjisajdoi....");
        }

    }
}
