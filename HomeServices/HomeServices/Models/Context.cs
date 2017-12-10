using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Protocols;

namespace netcore.Models
{
    public class PelleEventContext : DbContext
    {
        public DbSet<PelleEvent> PelleEvents { get; set; }
        public PelleEventContext(DbContextOptions<PelleEventContext> options) : base(options)
        {
        }

        public PelleEventContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PelleEvent>().HasIndex(e => e.Date);
        }
    }

    class PeopleContextDbFactory : IDesignTimeDbContextFactory<PelleEventContext>
    {
        private IConfigurationRoot Configuration { get; set; }

        public PeopleContextDbFactory()
        {
        }
        public PelleEventContext CreateDbContext(string[] args)
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

            var connectionString = Configuration.GetSection("DOCKER_INSTANCE").Value == "TRUE"
                ? Configuration.GetSection("ConnectionStrings:DefaultConnection").Value
                : Configuration.GetSection("ConnectionStrings:MigrationConnection").Value;

            return new PelleEventContext(new DbContextOptionsBuilder<PelleEventContext>()
                .UseSqlServer(connectionString)
                .Options);
        }
    }

}
