using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate
{
    public class DbMigrater
    {
        private readonly Logger _logger;
        public DbMigrater(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migrating !!!!....");
        }
    }
}
