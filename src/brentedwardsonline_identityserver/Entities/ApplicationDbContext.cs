using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace BrentEdwardsOnlineDotNetCore.Entities
{
    public class ApplicationDbContext : DbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<QualificationProvider> QualificationProviders { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Qualification>().ToTable("Qualifications");
            builder.Entity<QualificationProvider>().ToTable("QualificationProviders");
        }
    }

    
}
