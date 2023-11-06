using WilpSocialMedia.Activity.Domain.Model;
using WilpSocialMedia.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WilpSocialMedia.Activity.Infrastructure
{
    public class DataContextFactory : IDesignTimeDbContextFactory<Wilpsocialmedia_ActivityContext>
    {
        public Wilpsocialmedia_ActivityContext CreateDbContext(string[] args)
        {
            // Used only for EF .NET Core CLI tools (update database/migrations etc.)
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            var config = builder.Build();

            var optionsBuilder = new DbContextOptionsBuilder<Wilpsocialmedia_ActivityContext>()
                .UseSqlServer(config.GetConnectionString(Global.DbConnection.ActivityConnection));

            return new Wilpsocialmedia_ActivityContext(optionsBuilder.Options);
        }
    }
}
