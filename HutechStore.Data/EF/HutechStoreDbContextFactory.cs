using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HutechStore.Data.EF
{
    public class HutechStoreDbContextFactory : IDesignTimeDbContextFactory<HutechStoreDbContext>
    {
        public HutechStoreDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("HutechStoreSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<HutechStoreDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new HutechStoreDbContext(optionsBuilder.Options);
        }
    }
}
