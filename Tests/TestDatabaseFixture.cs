using Cobit_19.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class TestDatabaseFixture
    {
        // Should use connection string from appsettings.json
        private const string ConnectionString = "Server=localhost; Database=CobitDb; User Id=user; Password=Password; Integrated Security=SSPI; Trusted_Connection=True; Encrypt=False;";

        private static readonly object _lock = new();
        private static bool _databaseInitialized;

        public TestDatabaseFixture()
        {
            lock (_lock)
            {
                if (!_databaseInitialized)
                {
                    using (var context = CreateContext())
                    {
                        context.Database.EnsureDeleted();
                        context.Database.EnsureCreated();

                        context.SaveChanges();
                    }

                    _databaseInitialized = true;
                }
            }
        }

        public AppDbContext CreateContext()
            => new AppDbContext(
                new DbContextOptionsBuilder<AppDbContext>()
                    .UseSqlServer(ConnectionString)
                    .Options);
    }
}