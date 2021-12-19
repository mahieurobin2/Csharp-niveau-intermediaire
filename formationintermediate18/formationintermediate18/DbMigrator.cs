using System;

namespace formationintermediate18
{
    public class DbMigrator
    {
        private readonly ILogger _logger;
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migrating started at {0}" + DateTime.Now);

            // Details de la migration de la base de données

            _logger.LogInfo("Miggrating finished at {0}" + DateTime.Now);
        }
    }
}
