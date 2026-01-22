using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandSoft.Data
{
    public class LandSoftContextFactory : IDesignTimeDbContextFactory<LandSoftContext>
    {
        public LandSoftContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<LandSoftContext>();
            builder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            return new LandSoftContext(builder.Options);
        }
    }
}
