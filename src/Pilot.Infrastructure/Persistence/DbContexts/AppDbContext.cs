using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.DependencyInjection;
using Pilot.Domain.Entities;

namespace Pilot.Infrastructure.Persistence.DbContexts
{
    public class AppDbContext : DbContext
    {
        // Constructor: Initializes a new instance of the AppDbContext class with the provided DbContextOptions.
        public AppDbContext(DbContextOptions options) : base(options) { }

        // DbSet properties: Represent database tables for specific entities.
        public DbSet<Match> Matches { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Referee> Referees { get; set; }
        public DbSet<Team> Teams { get; set; }

        // Add more entities here

        // Method: Called when the model for a derived context is being created.
        // Responsible for configuring the database schema and other aspects of the model.
        protected override void OnModelCreating (ModelBuilder builder)
        {
            // It is not necessary when using MSSQL; the default schema is public.
            // builder.HasDefaultSchema("public");

            // EntityConfigurations mapping: Applies entity configurations from the current assembly. 
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // Call the base class method to ensure any by default and additional configuration is applied.
            base.OnModelCreating(builder);
        }
    }
}